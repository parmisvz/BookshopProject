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
            if (username.Text == "")
            {
                username.Text = obj.user_name;
                name.Text = obj.name;
                phone.Text = obj.phone_number;
                password.Text = obj.password;
            }
            else
            {
                username.Text = "";
                name.Text = "";
                phone.Text = "";
                password.Text = "";
            }

        }
        private void Edit(object sender, RoutedEventArgs e)
        {
            Admin.Admins.Remove(obj);
            obj.name = name.Text;
            obj.phone_number = phone.Text;
            obj.password = password.Text;
            MessageBox.Show("Your information edited successfully.");
            Admin.Admins.Add(new Admin(username.Text, password.Text, name.Text, phone.Text));
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
            AdminUserSearch adminUserSearch=new AdminUserSearch();
            adminUserSearch.Show();
        }

        private void AddBooks_Checked(object sender, RoutedEventArgs e)
        {
            AdminAddedBooks adminAddedBooks = new AdminAddedBooks();
            adminAddedBooks.Show();
        }
    }
}

