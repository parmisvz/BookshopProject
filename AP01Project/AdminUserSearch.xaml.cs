using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminUserSearch.xaml
    /// </summary>
    public partial class AdminUserSearch : Window
    {
        public AdminUserSearch()
        {
            InitializeComponent();
        }        
        public void SearchQuery(string value)
        {
            //string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathParmis);
            con.Open();
            string command;
            command = "select * from TUserInfo Where user_name Like '%" + value + "%' or name Like '%" + value + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data1 = new DataTable();
            adapter.Fill(data1);            
            dataGridUsers.ItemsSource = data1.DefaultView;
        }
        private void backtodash(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void ShowFilteredUsers_Click(object sender, RoutedEventArgs e)
        {            
            SearchQuery(SearchBoxUser.Text);
        }
        private void ShowUsers_Click(object sender, RoutedEventArgs e)
        {
            SearchQuery("");
        }
    }
}
