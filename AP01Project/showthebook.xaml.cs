using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for showthebook.xaml
    /// </summary>
    public partial class showthebook : Window
    {
        User obj;
        string x;
        public showthebook(User obj, string x)
        {
            InitializeComponent();
            this.obj = obj;
            this.x=x;


            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            // string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathZahra);
            string Command = "select * from TBookInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            ObservableCollection<Book> list = new ObservableCollection<Book>();
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                if (int.Parse(dataT.Rows[i][0].ToString()) == int.Parse(x))
                {

                    Book y = new Book(int.Parse(dataT.Rows[i][0].ToString()), dataT.Rows[i][1].ToString(), dataT.Rows[i][3].ToString(), int.Parse(dataT.Rows[i][4].ToString()), 0);
                    y.Image = dataT.Rows[i][5].ToString();
                    
                    list.Add(y);

                }
            }

            


           // MessageBox.Show(list.Count.ToString());

            showbook.ItemsSource = list;
            
           
        }

        private void back(object sender, RoutedEventArgs e)
        {
            bookslist bookslist = new bookslist(obj);
            bookslist.Show();
            this.Close();
        }
    }
}
