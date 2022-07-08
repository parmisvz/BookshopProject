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

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminSearchAndEditBooks.xaml
    /// </summary>
    public partial class AdminSearchAndEditBooks : Window
    {
        public AdminSearchAndEditBooks()
        {
            InitializeComponent();
        }
        public void SearchQuery(string value)
        {          
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathParmis);
            con.Open();
            string command;
            command = "select * from TBookInfo Where Name Like '%" + value + "%' or Author Like '%" + value + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridBooks.ItemsSource = data.DefaultView;
        }
        public void DeleteQueryShow(int value)
        {
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathParmis);
            con.Open();
            string command;
            command = "select * from TBookInfo Where Id = '" + value + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridBooks.ItemsSource = data.DefaultView;
        }
        private void ShowFilteredUsers_Click(object sender, RoutedEventArgs e)
        {
            SearchQuery(SearchBoxUser.Text);
        }
        private void ShowUsers_Click(object sender, RoutedEventArgs e)
        {
            SearchQuery("");
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteQueryShow(int.Parse(TextBoxEdit.Text));

            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathParmis);
            con.Open();
            string command;
            command = "Delete from TBookInfo Where Id = '" + int.Parse(TextBoxEdit.Text) + "' ";
            SqlCommand sqlCommand= new SqlCommand(command, con);
            sqlCommand.BeginExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfuly");
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            AdminEditBook adminEditBook=new AdminEditBook(int.Parse(TextBoxEdit.Text));
            adminEditBook.Show();
            this.Close();
        }
        private void backtodash(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
