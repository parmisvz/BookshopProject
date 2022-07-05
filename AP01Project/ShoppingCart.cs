using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP01Project
{
    public class ShoppingCart
    {
        public List<Book> SelectedBooks =new List<Book>();
        public int TotalPrice { get; set; }
        public int TotalDiscount { get; set; }
        public ShoppingCart()
        {

        }
    }
}
