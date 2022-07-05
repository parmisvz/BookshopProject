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

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminChoose.xaml
    /// </summary>
    public partial class AdminChoose : Window
    {
        public AdminChoose()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void admin_signup(object sender, RoutedEventArgs e)
        {
            AdminSignUp window6 = new AdminSignUp();
            window6.Show();
            this.Close();
        }
        private void admin_signin(object sender, RoutedEventArgs e)
        {
            AdminSignIn window2 = new AdminSignIn();
            window2.Show();
            this.Close();
        }
    }
}
