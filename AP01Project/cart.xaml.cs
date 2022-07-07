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

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for cart.xaml
    /// </summary>
    public partial class cart : Window
    {
        User obj;
        public cart(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void show_books(object sender, RoutedEventArgs e)
        {
            cart2.ItemsSource = obj.Library;
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < obj.Library.Count; i++)
            {
                if (obj.Library[i].Id == int.Parse(shenase.Text))
                {
                    obj.Library.RemoveAt(i);
                    cart2.Items.Refresh();
                }
            }
        }

        private void backtodash(object sender, RoutedEventArgs e)
        {
            UserDashboard x = new UserDashboard(obj);
            x.Show();
            this.Close();
        }
    }
}