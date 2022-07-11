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
                if (title.Text == "" || Address.Text == "" || Author.Text == "" || Image.Text == "" || Discount.Text == "")
                {
                    throw new Exception("Please fill all the fields");
                }
                if (int.Parse(Discount.Text) < 0)
                {
                    throw new Exception("Discount can not be negative");
                }
                if (int.Parse(Price.Text) < 0)
                {
                    throw new Exception("Price can not be negative");
                }
                if (int.Parse(PublishedDate.Text) < 0)
                {
                    throw new Exception("Published Date can not be negative");
                }
                else
                {
                    int nSoldItem = 0, rating = 0;
                    string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
                    string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection con = new SqlConnection(pathZahra);
                    con.Open();
                    string commandAdd;
                    commandAdd = "INSERT INTO TBookInfo(Title,Address,Author,Price,Image,Rating,Description,Discount,NoSoldItem,PublishedDate) VALUES('" + title.Text + "','" + Address.Text + "','" + Author.Text + "','" + int.Parse(Price.Text) + "','" + Image.Text + "','" + rating + "','" + Description.Text+ "','" + int.Parse(Discount.Text) + "' ,'" + nSoldItem + "', '"+ int.Parse(PublishedDate.Text)+ "')";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(commandAdd, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Added Successfuly");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
