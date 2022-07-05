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
    /// Interaction logic for UserChoose.xaml
    /// </summary>
    public partial class UserChoose : Window
    {
        public UserChoose()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void show_signup(object sender, RoutedEventArgs e)
        {
            // user user = user.finduser();
            UserSignIn firstwindow = new UserSignIn();
            firstwindow.Show();
            this.Close();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void show_signin(object sender, RoutedEventArgs e)
        {
            UserSignUp firstwindow = new UserSignUp();
            firstwindow.Show();
            this.Close();
        }
    }
}


