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
    /// Interaction logic for Cursuri.xaml
    /// </summary>
    public partial class Cursuri : Page
    {
        private Baza_de_date_StudentiEntities1 db = new Baza_de_date_StudentiEntities1();
        private List<int> listaAni = new List<int> { 1, 2, 3, 4, 5, 6 };
        private List<int> listaSemsestre = new List<int> { 1, 2 };
        private int an = 0;
        private int semestru = 0;
        private Student student;

        public Cursuri(Student student)
        {           
            InitializeComponent();
            this.student = student;
            InistilizareComboBox();
        }

        private void InistilizareComboBox()
        {
            cmbAni.ItemsSource = listaAni;
            cmbSemestru.ItemsSource = listaSemsestre;
        }

        private void cmbAni_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            an = int.Parse(cmbAni.SelectedItem.ToString());
            if (an != 0 && semestru != 0)
            {
                afisareCursuri();
            }
        }

        private void cmbSemestru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            semestru = int.Parse(cmbSemestru.SelectedItem.ToString());
            if (an != 0 && semestru != 0)
            {
                afisareCursuri();
            }
        }

        private void afisareCursuri()
        {
            var listaCursuri = db.Curs.Where(x => x.An == an && x.Semestru == semestru && x.IdSpecializare == student.IdSpecializare).ToList();
            dgCursuri.ItemsSource = listaCursuri;
        }
    }
}
