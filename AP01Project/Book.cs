using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP01Project
{
    public class Book
    {
        public List<Book> Books=new List<Book>();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public bool VIP { get; set; }
        public int Rating { get; set; }
        public Book()
        {

        }
    }
}
