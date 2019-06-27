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
using System.Windows.Shapes;

namespace AplicatiePRC
{
    /// <summary>
    /// Interaction logic for AplicatieStudent.xaml
    /// </summary>
    public partial class AplicatieStudent : Window
    {
        private Student student = new Student();
        private int tipUser;

        public AplicatieStudent(Student student, int tipUser)
        {
            InitializeComponent();
            this.student = student;
            this.tipUser = tipUser;
            lbNumeStudent.Content = student.Nume + " " + student.Prenume + "  |";
            selectTypeUser();
            frame.NavigationService.Navigate(new PaginaPrincipala(student));
        }

        //Urmeaza modificarea pentru fiecare tip de user
        private void selectTypeUser()
        {
            if (tipUser == 2)
            {
                btnadaugaNota.Visibility = Visibility.Collapsed;
            }
        }

        private void btnIesire_Click(object sender, RoutedEventArgs e)
        {
            student = null;
            MainWindow logare = new MainWindow();
            logare.Show();
            this.Close();
        }

        private void btnNoteleMele_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PaginaNote(student));
        }

        private void btnAcasa_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PaginaPrincipala(student));
        }

        private void btnCursuri_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Cursuri(student));
        }

        private void btnColegi_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PaginaColegi(student)); 
        }

        private void btnadaugaNota_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new AdaugaNota());
        }

        private void btnStudentiBursieri_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new PaginaStudentiBursieri(student));
        }
    }
}
