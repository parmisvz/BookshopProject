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
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for SHOWBOOK.xaml
    /// </summary>
    public partial class SHOWBOOK : Window
    {
        Admin obj;
        string pdfAddress;
        public SHOWBOOK(Admin obj)
        {
            InitializeComponent();
            this.obj = obj;
        }
        private void back(object sender, RoutedEventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard(obj);
            admindashboard.Show();
            this.Close();
        }
        private void pdf(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            string file = @"" + pdfAddress;
            process.StartInfo.FileName = file;
            process.Start();
        }
        private void SHOW(object sender, RoutedEventArgs e)
        {
            //string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathParmis);
            string Command = "select * from TBookInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            ObservableCollection<Book> list = new ObservableCollection<Book>();
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                if (int.Parse(dataT.Rows[i][0].ToString()) == int.Parse(search.Text.ToString()))
                {

                    Book y = new Book(int.Parse(dataT.Rows[i][0].ToString()), dataT.Rows[i][1].ToString(), dataT.Rows[i][2].ToString(), int.Parse(dataT.Rows[i][4].ToString()), int.Parse(dataT.Rows[i][8].ToString()));
                    y.Image = dataT.Rows[i][5].ToString();
                    pdfAddress= dataT.Rows[i][2].ToString();
                    list.Add(y);
                }
            }
            // MessageBox.Show(list.Count.ToString());
            showbook.ItemsSource = list;
        }

    }
}
