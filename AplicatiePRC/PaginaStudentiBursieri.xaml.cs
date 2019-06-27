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
    /// Interaction logic for PaginaStudentiBursieri.xaml
    /// </summary>
    public partial class PaginaStudentiBursieri : Page
    {
        public PaginaStudentiBursieri(Student student)
        {
            Baza_de_date_StudentiEntities1 db = new Baza_de_date_StudentiEntities1();
            InitializeComponent();
            var listaStudenti = db.Student.Where(x => x.IdSpecializare == student.IdSpecializare).ToList();
            List<SituatieStudenti> listaStdMed = new List<SituatieStudenti>();
            foreach (var s in listaStudenti)
            {
                int nrCredite = 0;
                int an = 1;
                int semestru = 1;
                bool integralist = true;
                var listaNote = db.Nota.Where(x => x.Student.IdStudent == s.IdStudent && x.Student.IdSpecializare == student.IdSpecializare && x.Curs.An == an && x.Curs.Semestru == semestru).ToList();
                foreach (var n in listaNote)
                {
                    nrCredite += n.Calificativ * n.Curs.NumarCredite; 
                    if(n.Calificativ < 5)
                    {
                        integralist = false;
                    }
                }

                listaStdMed.Add(new SituatieStudenti(s.Nume, s.Prenume, nrCredite,integralist));

            }
          
            dgSituatieStudetini.ItemsSource = listaStdMed.OrderByDescending(X=>X.nrCredite);
        }
    }
}
