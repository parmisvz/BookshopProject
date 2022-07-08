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
            //string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //// string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //SqlConnection sqlConnection = new SqlConnection(pathZahra);
            //string Command = "select * from TUserInfo";
            //SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            //DataTable dataT = new DataTable();
            //adapter.Fill(dataT);
            //int j = 0;
            //string[] boughtbooks
            //    ;
            //for (int i = 0; i < dataT.Rows.Count; i++)
            //{
            //    if (dataT.Rows[i][0].ToString() == obj.user_name)
            //    {

            //        boughtbooks = dataT.Rows[i][5].ToString().Split(' ');
            //        j = boughtbooks.Length;
            //        for (int x = 0; x < j; x++)
            //        {
            //            string pathzahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //            // string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //            SqlConnection sqlConn = new SqlConnection(pathzahra);
            //            string Comm = "select * from TBookInfo Where Id='" + boughtbooks[x] + "'";
            //            SqlDataAdapter adapt = new SqlDataAdapter(Comm, sqlConn);
            //            DataTable data = new DataTable();
            //            adapt.Fill(data);

            //            string s = data.Rows[int.Parse(boughtbooks[x])-1][0].ToString();
            //            string name = data.Rows[int.Parse(boughtbooks[x])-1][1].ToString();
            //            string author = data.Rows[int.Parse(boughtbooks[x])-1][2].ToString();
            //            int price = int.Parse(data.Rows[int.Parse(boughtbooks[x])-1][3].ToString());
            //            Book book = new Book(int.Parse(s), name, author, price, 0);
            //            book.Image = data.Rows[int.Parse(boughtbooks[x])-1][4].ToString();
            //            book.Pdf = data.Rows[int.Parse(boughtbooks[x])-1][5].ToString();
            //            obj.Library.Add(book);
            //        }
            //    }
            //}

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
            String ee = obj.user_name;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf; Integrated Security = True; Connect Timeout = 30");
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

            SqlConnection con2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf; Integrated Security = True; Connect Timeout = 30");
            con2.Open();
            string command2 = "INSERT INTO TUserInfo (user_name,password,name,phone_number,mojodi,bought) values('" + obj.user_name + "','" + obj.password + "','" + obj.name + "','" + obj.phone_number + "','" + obj.mojodi + "','" + obj.savedbooks + "')";
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
