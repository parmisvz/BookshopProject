﻿using System;
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
            string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(pathParmis);
            con.Open();
            string command;
            command = "Select * from TBookInfo Where Id = '" + Id + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            string Title, author, address, price, image, description, discount;
            int nSoldItem, rating;
            Title = title.Text;
            address = Address.Text;
            author = Author.Text;
            price = Price.Text;
            image = Image.Text;
            rating = int.Parse(data.Rows[0][6].ToString());
            description = Description.Text;
            discount = Discount.Text;
            nSoldItem = int.Parse(data.Rows[0][9].ToString());

            if (title.Text == "")
            {
                Title = data.Rows[0][1].ToString();
            }
            if (Address.Text == "")
            {
                address = data.Rows[0][2].ToString();
            }
            if (Author.Text == "")
            {
                author = data.Rows[0][3].ToString();
            }
            if (Price.Text == "")
            {
                price = data.Rows[0][4].ToString();
            }
            if (Image.Text=="")
            {
                image=data.Rows[0][5].ToString();
            }
            if (Description.Text=="")
            {
                description=data.Rows[0][7].ToString();
            }
            if (Discount.Text == "")
            {
                discount = data.Rows[0][8].ToString();
            }
            string commandD;
            commandD = "Delete from TBookInfo Where Id = '" + Id + "' ";
            SqlCommand sqlCommand = new SqlCommand(command, con);
            sqlCommand.BeginExecuteNonQuery();

            string commandAdd;
            commandAdd = "INSERT INTO TBookInfo(Title,Address,Author,Price,Image,Rating,Description,Discount,NoSoldItms) VALUES('" + Title + "','" + address +"','" + author +"','" + int.Parse(price) +"','" + image +"','" + rating +"','" + Description +"','" + int.Parse(discount) +"' ,'" + nSoldItem +"')";
            SqlCommand sqlCommandAdd = new SqlCommand(command, con);
            sqlCommandAdd.BeginExecuteNonQuery();

            MessageBox.Show("Edited Sucessfuly");
            this.Close();
        }
    }
}