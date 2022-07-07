using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace AP01Project
{
    public class Book
    {
        public List<Book> Books = new List<Book>();
        public List<int> BookRating=new List<int>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool VIP { get; set; }
        public int Rating { get; set; }
        public Book(int id, string name, string author, int price)
        {
            Id = id;
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
