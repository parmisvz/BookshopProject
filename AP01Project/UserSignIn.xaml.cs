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
    /// Interaction logic for UserSignIn.xaml
    /// </summary>
    public partial class UserSignIn : Window
    {
        public UserSignIn()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void enter(object sender, RoutedEventArgs e)
        {
            try
            {
                if (User.checkuser(user_name.Text, password.Password))
                {
                    UserDashboard userdashboard = new UserDashboard();
                    userdashboard.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("The information is wrong.you cant enter.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

