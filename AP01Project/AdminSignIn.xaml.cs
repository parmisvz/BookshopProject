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
using System.Data.SqlClient;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminSignIn.xaml
    /// </summary>
    public partial class AdminSignIn : Window
    {
        public AdminSignIn()
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
        private void enter_admin(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Admin.checkadmin(user_name.Text, password.Password))
                {
                    string name = User.Name(user_name.Text);
                    string phone = User.Phone_number(user_name.Text);
                    Admin person = new Admin(user_name.Text, password.Password, name, phone);
                    AdminDashboard userdashboard = new AdminDashboard(person);
                    userdashboard.Show();
                    Console.WriteLine();
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

