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
    /// Interaction logic for PaginaPrincipala.xaml
    /// </summary>
    public partial class PaginaPrincipala : Page
    {
        Student student;
        public PaginaPrincipala(Student student)
        {
            InitializeComponent();
            this.student = student;    
        }

        private void btnSP_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnNot_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PaginaNote(student));
        }

        private void btnColeg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PaginaColegi(student));
        }

        private void btnRest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
