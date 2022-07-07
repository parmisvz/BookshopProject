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
        DataTable data = new DataTable();
        string filterField = "UserName";
        private void show_books(object sender, RoutedEventArgs e)
        {
            string path= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\WpfApp1\data\user2.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con=new SqlConnection(path);
            con.Open();
            string command;
            command = "select * from TUserInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            adapter.Fill(data);
            dataGridbooks.ItemsSource = data.DefaultView;
        }
        private void backtodash(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void SearchBoxUser_TextChanged(object sender,TextChangedEventArgs e)
        {
            data.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, SearchBoxUser.Text);
        }
    }
}
