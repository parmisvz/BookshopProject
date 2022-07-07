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
    /// Interaction logic for bookslist.xaml
    /// </summary>
    public partial class bookslist : Window
    {
        User obj;
        public bookslist(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void show_books(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string command;
            command = "select * from TBookinfo";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridbooks.ItemsSource = data.DefaultView;
        }

        private void add_tocart(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string command;
            command = "select * from TBookinfo";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            int x = int.Parse(shenase.Text.ToString());
            int index = int.Parse(data.Rows[x - 1][0].ToString());
            string name = data.Rows[x - 1][1].ToString();
            string author = data.Rows[x - 1][2].ToString();
            int price = int.Parse(data.Rows[x - 1][3].ToString());
            Book book = new Book(index, name, author, price);
            obj.Library.Add(book);
            MessageBox.Show("The book added successfully to your cart.");
        }

        private void backtodash(object sender, RoutedEventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(obj);
            userDashboard.Show();
            this.Close();

        }
    }
}