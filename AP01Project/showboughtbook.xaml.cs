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
using System.Diagnostics;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for showboughtbook.xaml
    /// </summary>
    public partial class showboughtbook : Window
    {
        User obj;
        Book book;
        public showboughtbook(User obj, Book book)
        {
            this.obj = obj;
            InitializeComponent();
            this.book = book;
         List<Book> books = new List<Book>();
            books.Add(book);
            showbook.ItemsSource = books;

         }

        private void pdf(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            string file = @"" + book.Pdf;
            process.StartInfo.FileName = file;
            process.Start();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            bought bought=new bought(obj);
            bought.Show();
            this.Close();
        }
    }
}
