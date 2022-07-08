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
    /// Interaction logic for BookMark.xaml
    /// </summary>
    public partial class  BookMark : Window
    {
        User obj;
        public BookMark(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void show_books(object sender, RoutedEventArgs e)
        {
            cart2.ItemsSource = obj.Library;
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < obj.Library.Count; i++)
            {
                if (obj.Library[i].Id == int.Parse(shenase.Text))
                {
                    obj.Library.RemoveAt(i);
                    cart2.Items.Refresh();
                }
            }
        }
        private void backtodash(object sender, RoutedEventArgs e)
        {
            UserDashboard x = new UserDashboard(obj);
            x.Show();
            this.Close();
        }

        private void bookmark(object sender, RoutedEventArgs e)
        {



            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            // string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathZahra);
            string Command = "select * from TBookInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            for(int i = 0;i < dataT.Rows.Count; i++)
            {
                if(dataT.Rows[i][0].ToString() == shenase.Text.ToString())
                {
                    int x=int.Parse(dataT.Rows[i][0].ToString());
                    string name=dataT.Rows[i][1].ToString();
                    string author=dataT.Rows[i][2].ToString();
                    int price=int.Parse(dataT.Rows[i][3].ToString());
                    Book book = new Book(x, name, author, price, 0);
                    obj.bookmark.Add(book);
                    cart2.ItemsSource=obj.bookmark;
                    cart2.Items.Refresh();
                }
            }
        }
    }
}
