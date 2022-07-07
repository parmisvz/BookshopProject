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

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for BuyBook.xaml
    /// </summary>
    public partial class BuyBook : Window
    {
        public BuyBook()
        {
            InitializeComponent();
        }
        private void Buy(object sender, RoutedEventArgs e)
        {
            if (!User.LuhnCheck(Int64.Parse(CardNo.Text)))
            {
                throw new Exception("Ivalid Card no");
            }
            if (CVV2.Text.Length!=2 || CVV2.Text.Length != 3)
            {
                throw new Exception("Ivalid cvv2");
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
