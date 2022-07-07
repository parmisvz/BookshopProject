using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace AP01Project
{
    public class Book
    {
        public List<Book> Books { get; set; }
        public List<int> AllRating { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool VIP { get; set; }
        public int Rating { get; set; }
        public Book()
        {
            Books = ReadFromSQLAddToList();
        }
        public static List<Book> ReadFromSQLAddToList()
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(path);
            string Command = "select * from TBookInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            
            List<Book> list = new List<Book>();
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                Book temoAdmin = new Book(/*dataT.Rows[i][0].ToString(), dataT.Rows[i][2].ToString(), dataT.Rows[i][1].ToString(), dataT.Rows[i][3].ToString()*/);
                list.Add(temoAdmin);
            }
            return list;
        }
    }
}
