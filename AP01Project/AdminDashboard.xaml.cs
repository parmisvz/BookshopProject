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
using System.Text.RegularExpressions;


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
            try
            {
                if (!Regex.IsMatch(password.Text, @"^(?=.*?[A-Z])(?=.*?[a-z]).{8,40}"))
                {
                    throw new Exception("Password is not valid");
                }
                if (!Regex.IsMatch(phone.Text, @"^[09][0-9]{9}"))
                {
                    throw new Exception("Your phone number is not valid.");
                }
                if (name.Text.Length < 3 || name.Text.Length > 32 || !Regex.IsMatch(name.Text, @"[a-zA-Z]"))
                {
                    throw new Exception("name is not valid.");
                }
                else
                {
                    obj.name = name.Text;
                    obj.phone_number = phone.Text;
                    obj.password = password.Text;
                    //delete 
                    string ee = obj.user_name;
                    string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\AdminInfo.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection sqlConnection = new SqlConnection(pathParmis);                   
                    SqlCommand a = new SqlCommand();
                    a.CommandText = "Delete from TAdminInfo Where AdminUserName = @ee";
                    SqlDataAdapter vv =new SqlDataAdapter();
                    vv.DeleteCommand = a;
                    vv.DeleteCommand.Parameters.Add("@ee", SqlDbType.NVarChar).Value = obj.user_name;
                    vv.DeleteCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    vv.DeleteCommand.ExecuteNonQuery();
                    sqlConnection.Dispose();
                    sqlConnection.Close();

                    //insert 
                    SqlConnection sqlConnectionInsert = new SqlConnection(pathParmis);
                    sqlConnectionInsert.Open();
                    string commandInsert = "Insert Into TAdminInfo(AdminUserName,AdminName,AdminPassword,AdminPhoneNo) Values('" + obj.user_name + "','" + name.Text + "','" + password.Text + "','" + phone.Text + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(commandInsert, sqlConnectionInsert);
                    adapter.InsertCommand.ExecuteNonQuery();
                    sqlConnectionInsert.Close();



                    MessageBox.Show("Your information edited successfully.");                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AccountBalance_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Account Balance:{0}", shop.mojodi.ToString());
        }

        private void SearchBookForm_Checked(object sender, RoutedEventArgs e)
        {
            AdminSearchAndEditBooks adminSearchAndEditBooks=new AdminSearchAndEditBooks();
            adminSearchAndEditBooks.Show();
        }

        private void SearchUserForm_Checked(object sender, RoutedEventArgs e)
        {
            AdminUserSearch adminUserSearch=new AdminUserSearch();
            adminUserSearch.Show();
        }

        private void AddBooks_Checked(object sender, RoutedEventArgs e)
        {
            AdminAddBook adminAddedBooks = new AdminAddBook();
            adminAddedBooks.Show();
        }

        private void BackToLogin_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SHOWBOOK(object sender, RoutedEventArgs e)
        {
            SHOWBOOK showbook = new SHOWBOOK(obj);
            showbook.Show();
            this.Close();
        }
    }
}

