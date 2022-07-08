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
using System.Data.SqlClient;
using System.Data;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for AdminAddBook.xaml
    /// </summary>
    public partial class AdminAddBook : Window
    {
        public AdminAddBook()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Title, author, address, price, image, description, discount;
                int nSoldItem, rating;
                Title = title.Text;
                address = Address.Text;
                author = Author.Text;
                price = Price.Text;
                image = Image.Text;
                rating =0;
                description = Description.Text;
                discount = Discount.Text;
                nSoldItem = 0;
                string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(pathParmis);
                string commandAdd;
                commandAdd = "INSERT INTO TBookInfo(Title,Address,Author,Price,Image,Rating,Description,Discount,NoSoldItms) VALUES('" + Title + "','" + address + "','" + author + "','" + int.Parse(price) + "','" + image + "','" + rating + "','" + Description + "','" + int.Parse(discount) + "' ,'" + nSoldItem + "')";
                SqlCommand sqlCommandAdd = new SqlCommand(commandAdd, con);
                sqlCommandAdd.BeginExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
