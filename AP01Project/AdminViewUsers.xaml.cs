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
    /// Interaction logic for AdminViewUsers.xaml
    /// </summary>
    public partial class AdminViewUsers : Window
    {
        public AdminViewUsers()
        {
            InitializeComponent();
        }
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection SConnection = new SqlConnection();
            SConnection.Open();
            string Command = "select * from TUserInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, SConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
                Console.WriteLine("UserName:{0} Name:{1} PhoneNo:{2} AccountBalance:{3}", dataTable.Rows[i][0], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4]);
            SqlCommand SCommand = new SqlCommand(Command, SConnection);
            SCommand.BeginExecuteNonQuery();
            SConnection.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
