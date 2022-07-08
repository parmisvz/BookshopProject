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
    /// Interaction logic for buywithbalance.xaml
    /// </summary>
    public partial class buywithbalance : Window
    {
        User obj;
        public buywithbalance(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }
        private void Buy(object sender, RoutedEventArgs e)
        {
            try
            {
               
              
                    int sum = 0;
                    for(int i = 0; i < obj.Library.Count; i++)
                    {
                        sum += obj.Library[i].Price;
                    }
                    if (sum <= obj.mojodi)
                    {
                        obj.mojodi -= sum;
                        MessageBox.Show("Thanks for your shop.");
                        for (int i = 0; i < obj.Library.Count; i++)
                        {
                            obj.bought.Add(obj.Library[i]);
                            obj.savedbooks=obj.savedbooks+obj.Library[i].Id.ToString()+" ";
                        }
                    }
                    else
                    {
                        throw new Exception("you dont have enough money in your account");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(obj);
            userDashboard.Show();
            this.Close();
        }

        private void price(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < obj.Library.Count; i++)
            {
                sum += obj.Library[i].Price;
            }
            total.Text = sum.ToString();
        }
    }
}
