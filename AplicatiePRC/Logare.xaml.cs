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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Baza_de_date_StudentiEntities1 db = new Baza_de_date_StudentiEntities1();
        private Student student = new Student();
        private int tipUser; 
        public MainWindow()
        {
            InitializeComponent();       
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            if(Logare())
            {
                AplicatieStudent app = new AplicatieStudent(student, tipUser);
                app.Show();
                this.Close();
            }
            else
            {
                lbAutentificareEsuata.Visibility = Visibility.Visible;
            }
        }

        private bool Logare()
        {
            Cont cont = db.Cont.Where(x => x.username == tbUser.Text && x.password == tbPass.Password).SingleOrDefault();
            if (cont != null)
            {
                student = db.Student.Where(x => x.IdStudent == cont.IdStudent).Single();
                tipUser = 1;
                return true;
            }

            return false;
        }

        private void btnAnulare_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
