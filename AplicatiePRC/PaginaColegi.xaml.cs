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
    /// Interaction logic for PaginaColegi.xaml
    /// </summary>
    public partial class PaginaColegi : Page
    {
        private Baza_de_date_StudentiEntities1 db = new Baza_de_date_StudentiEntities1();
        private Student student;
        public PaginaColegi(Student student)
        {
            InitializeComponent();
            this.student = student;
            var listaColegi = db.Student.Where(x => x.IdSpecializare == student.IdSpecializare && x.IdStudent != student.IdStudent).ToList();

            dgStudenti.ItemsSource = listaColegi;
        }
    }
}
