using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AplicatiePRC
{
    /// <summary>
    /// Interaction logic for AdaugaNota.xaml
    /// </summary>
    public partial class AdaugaNota : Page
    {
        Baza_de_date_StudentiEntities1 db = new Baza_de_date_StudentiEntities1();

        List<Facultate> listaFacultati;
        public AdaugaNota()
        {
            InitializeComponent();
            
            listaFacultati = db.Facultate.ToList();
            cbFacultate.ItemsSource = listaFacultati.ToList();
        }


        private void cbSpecializari_DropDownOpened(object sender, EventArgs e)
        {
            if (cbFacultate.SelectedItem != null)
            {
                int facSelectata = int.Parse(cbFacultate.SelectedValue.ToString());
                var listaSpecializari = db.Specializare.Where(x => x.Facultate.IdFacultate == facSelectata).ToList();
                cbSpecializari.ItemsSource = listaSpecializari;  
            }
        }

        private void cbDenCurs_DropDownOpened(object sender, EventArgs e)
        {
            if(cbSpecializari.SelectedItem != null)
            {
                int specSelecata = int.Parse(cbSpecializari.SelectedValue.ToString());
                var listaCursuri = db.Curs.Where(x => x.Specializare.IdSpecializare == specSelecata).ToList();
                cbDenCurs.ItemsSource = listaCursuri;
            }      
        }

        private void cbStudent_DropDownOpened(object sender, EventArgs e)
        {
            if (cbSpecializari.SelectedItem != null)
            {
                int specSelecata = int.Parse(cbSpecializari.SelectedValue.ToString());
                var listaStdudenti = db.Student.Where(x => x.Specializare.IdSpecializare == specSelecata).ToList();
                cbStudent.ItemsSource = listaStdudenti;
            }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            int nota = 0;
            try
            {
                nota = int.Parse(tbNota.Text);
            }
            catch
            {
                nota = 0;
            }

            if (cbFacultate.SelectedItem != null && cbSpecializari.SelectedItem != null && cbStudent.SelectedItem != null && nota != 0)
            {
                int idCurs = int.Parse(cbDenCurs.SelectedValue.ToString());
                int idStudent = int.Parse(cbStudent.SelectedValue.ToString());
                var check = db.Nota.Where(x => x.IdCurs == idCurs && x.IdStudent == idStudent).SingleOrDefault();
                if(check != null){
                    check.Calificativ = nota;
                    db.SaveChanges();
                    this.NavigationService.Navigate(new AdaugaNota());
                }
                else
                {
                    Nota n = new Nota();
                    n.IdCurs = int.Parse(cbDenCurs.SelectedValue.ToString());
                    n.IdStudent = int.Parse(cbStudent.SelectedValue.ToString());
                    n.Calificativ = nota;
                    n.DataAdaugare = DateTime.Now;
                    db.Nota.Add(n);
                    db.SaveChanges();
                    this.NavigationService.Navigate(new AdaugaNota());
                }
              
            }
            else
            {
                MessageBox.Show("Nu ati introdus date valide!");
            }
        }     
    }
}
