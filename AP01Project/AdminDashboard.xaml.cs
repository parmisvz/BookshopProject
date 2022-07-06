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
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        Admin obj;
        public AdminDashboard(Admin _obj)
        {
            this.obj = _obj;
            InitializeComponent();
        }
        private void ShowInformation(object sender, RoutedEventArgs e)
        {
            obj.user_name = username.Text;
            obj.name = name.Text;
            obj.phone_number = phone.Text;
        }
        private void Edit(object sender, RoutedEventArgs e)
        {

        }

        private void ViewUsers_Checked(object sender, RoutedEventArgs e)
        {
            AdminViewUsers adminViewUsers = new AdminViewUsers();
        }

        private void AddedBooks_Checked(object sender, RoutedEventArgs e)
        {
            AdminAddedBooks adminAddedBooks = new AdminAddedBooks();
            adminAddedBooks.Show();
        }

        private void AccountBalance_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBookForm_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SearchUserForm_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

