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
    /// Interaction logic for UserDashboard.xaml
    /// </summary>
    public partial class UserDashboard : Window
    {
        User obj;
        public UserDashboard(User obj)
        {
            this.obj = obj;
            InitializeComponent();
            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            // string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathZahra);
            string Command = "select * from TUserInfo where user_name='" + obj.user_name + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            string pathzahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConn = new SqlConnection(pathzahra);
            string Comm = "select * from TBookInfo";
            SqlDataAdapter adapt = new SqlDataAdapter(Comm, sqlConn);
            DataTable data = new DataTable();
            adapt.Fill(data);

            string[] boughtbooks;
            boughtbooks = dataT.Rows[0][5].ToString().Split(',');
            string[] bookmark = dataT.Rows[0][6].ToString().Split(',');
            if (bookmark.Length > 0)
            {
                for (int i = 0; i < bookmark.Length; i++)
                {
                    for (int j = 0; j < data.Rows.Count; j++)
                    {
                        if (data.Rows[j][0].ToString() == (bookmark[i]))
                        {
                            int a = int.Parse(data.Rows[j][0].ToString());
                            string name = data.Rows[j][1].ToString();
                            string author = data.Rows[j][3].ToString();
                            int price = int.Parse(data.Rows[j][4].ToString());
                            Book book = new Book(a, name, author, price, 0);
                            book.Image = data.Rows[j][5].ToString();
                            book.Pdf = data.Rows[j][2].ToString();
                            obj.bookmark.Add(book);
                        }
                    }
                }
            }
            if (boughtbooks.Length > 0)
            {

                for (int i = 0; i < boughtbooks.Length; i++)
                {
                    for (int j = 0; j < data.Rows.Count; j++)
                    {
                        if (data.Rows[j][0].ToString() == boughtbooks[i])
                        {
                            int a = int.Parse(data.Rows[j][0].ToString());
                            string name = data.Rows[j][1].ToString();
                            string author = data.Rows[j][3].ToString();
                            
                            int price = int.Parse(data.Rows[j][4].ToString());
                            Book book = new Book(a, name, author, price, 0);
                            book.Image = data.Rows[j][5].ToString();
                            book.Pdf = data.Rows[j][2].ToString();
                            book.Discount=int.Parse(data.Rows[j][8].ToString());
                            //obj.Library.Add(book);
                            obj.bought.Add(book);
                        }
                    }

                }
            }


        }


        private void open_userprofile(object sender, RoutedEventArgs e)
        {
            userprofile userprofile = new userprofile(obj);
            userprofile.Show();
            this.Close();
        }

        private void showbooks(object sender, RoutedEventArgs e)
        {
            bookslist bookslist = new bookslist(obj);
            bookslist.Show();
            this.Close();
        }

        private void cart(object sender, RoutedEventArgs e)
        {
            cart cart = new cart(obj);
            cart.Show();
            this.Close();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            obj.bookmarks = "";
            for (int i = 0; i < obj.bookmark.Count; i++)
            {
                if (obj.bookmarks == "")
                {
                    obj.bookmarks += obj.bookmark[i].Id;
                }
                else
                {
                    obj.bookmarks += "," + obj.bookmark[i].Id;
                }
            }
            obj.savedbooks = "";
            for (int i = 0; i < obj.bought.Count; i++)
            {
                if (obj.savedbooks == "")
                {
                    obj.savedbooks += obj.bought[i].Id;
                }
                else
                {
                    obj.savedbooks += "," + obj.bought[i].Id;
                }
            }
            String ee = obj.user_name;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter vv = new SqlDataAdapter();
            SqlCommand pp = new SqlCommand();
            pp.CommandText = "DELETE FROM TUserInfo where user_name=@ee";
            vv.DeleteCommand = pp;
            vv.DeleteCommand.Parameters.Add("@ee", SqlDbType.NVarChar).Value = obj.user_name;
            vv.DeleteCommand.Connection = con;
            con.Open();
            vv.DeleteCommand.ExecuteNonQuery();
            con.Dispose();
            con.Close();

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30");
            con2.Open();
            string command2 = "INSERT INTO TUserInfo (user_name,password,name,phone_number,mojodi,bought,bookmark) values('" + obj.user_name + "','" + obj.password + "','" + obj.name + "','" + obj.phone_number + "','" + obj.mojodi + "','" + obj.savedbooks + "','"+obj.bookmarks+"')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(command2, con2);

            adapter.InsertCommand.ExecuteNonQuery();
            con2.Close();
            App.Current.Shutdown();
        }

        private void BUY(object sender, RoutedEventArgs e)
        {
            BuyBook buyBook = new BuyBook(obj);
            buyBook.Show();
            this.Close();
        }

        private void exit_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Boughtbooks(object sender, RoutedEventArgs e)
        {
            bought bought = new bought(obj);
            bought.Show();
            this.Close();
        }

        private void buyonline(object sender, RoutedEventArgs e)
        {
            increasemojodi increasemojodi = new increasemojodi(obj);

            increasemojodi.Show();
            this.Close();

        }

        private void buywithbalance(object sender, RoutedEventArgs e)
        {
            buywithbalance x = new buywithbalance(obj);
            x.Show();
            this.Close();
        }

        private void bought(object sender, RoutedEventArgs e)
        {

        }

        private void bookmark(object sender, RoutedEventArgs e)
        {
            BookMark bookMark = new BookMark(obj);
            bookMark.Show();
            this.Close();
        }
    }

}
