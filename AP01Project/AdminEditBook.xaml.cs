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
    /// Interaction logic for AdminEditBook.xaml
    /// </summary>
    public partial class AdminEditBook : Window
    {
        int Id;
        public AdminEditBook(int ID)
        {
            this.Id = ID;
            InitializeComponent();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathZahra);
            con.Open();
            string command;
            command = "Select * from TBookInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            int x = 0;
            for(int i = 0; i < data.Rows.Count; i++)
            {
                if(int.Parse(data.Rows[i][0].ToString())==Id)
                {
                    x = i;
                    break;
                }
            }
            string Title, author, address, price, image, description, discount;
            int nSoldItem, rating, DPublished;
            
            if (title.Text == "")
            {
                Title = data.Rows[x][1].ToString();
            }
            if (Address.Text == "")
            {
                address = data.Rows[x][2].ToString();
            }
            if (Author.Text == "")
            {
                author = data.Rows[x][3].ToString();
            }
            if (Price.Text == "")
            {
                price = data.Rows[x][4].ToString();
            }
            if (Image.Text == "")
            {
                image = data.Rows[x][5].ToString();
            }
            if (Description.Text == "")
            {
                description = data.Rows[x][7].ToString();
            }
            if (Discount.Text == "")
            {
                discount = data.Rows[x][8].ToString();
            }
            if (DatePublished.Text == "")
            {
                DPublished = int.Parse(data.Rows[0][10].ToString());
            }
            else
            {
                Title = title.Text;
                address = Address.Text;
                author = Author.Text;
                price = Price.Text;
                image = Image.Text;
                DPublished = int.Parse(DatePublished.Text);
                rating = int.Parse(data.Rows[x][6].ToString());
                description = Description.Text;
                discount = Discount.Text;
                nSoldItem = int.Parse(data.Rows[x][9].ToString());
                //delete 
                int ee = Id;
                SqlConnection sqlConnection = new SqlConnection(pathZahra);
                SqlCommand a = new SqlCommand();
                a.CommandText = "Delete from TBookInfo Where Id = @ee";
                SqlDataAdapter vv = new SqlDataAdapter();
                vv.DeleteCommand = a;
                vv.DeleteCommand.Parameters.Add("@ee", SqlDbType.Int).Value = Id;
                vv.DeleteCommand.Connection = sqlConnection;
                sqlConnection.Open();
                vv.DeleteCommand.ExecuteNonQuery();
                sqlConnection.Dispose();
                sqlConnection.Close();

                //insert 
                SqlConnection sqlConnectionInsert = new SqlConnection(pathZahra);
                sqlConnectionInsert.Open();
                string commandInsert = "INSERT INTO TBookInfo(Title,Address,Author,Price,Image,Rating,Description,Discount,NoSoldItem,PublishedDate) VALUES('" + Title + "','" + address + "','" + author + "','" + int.Parse(price) + "','" + image + "','" + rating + "','" + description + "','" + int.Parse(discount) + "' ,'" + nSoldItem + "', '" + DPublished + "')";
                SqlDataAdapter adapterInsert = new SqlDataAdapter();
                adapterInsert.InsertCommand = new SqlCommand(commandInsert, sqlConnectionInsert);
                adapterInsert.InsertCommand.ExecuteNonQuery();
                sqlConnectionInsert.Close();


                MessageBox.Show("Edited Sucessfuly");
                this.Close();
            }
            
        }
    }
}
