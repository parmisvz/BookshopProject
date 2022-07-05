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
    /// Interaction logic for userprofile.xaml
    /// </summary>
    public partial class userprofile : Window
    {
        User obj;
        public userprofile(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void show_userinfo(object sender, RoutedEventArgs e)
        {
            username.Text = "Email: " + obj.user_name;
            name.Text = "Name: " + obj.name;
            phone.Text = "Phone: " + obj.phone_number;
            mojodi.Text = "Iinventory: " + obj.mojodi.ToString();

        }

        private void edit_userinfo(object sender, RoutedEventArgs e)
        {
            obj.user_name = username.Text;
            obj.name = name.Text;
            obj.phone_number = phone.Text;
            obj.mojodi = int.Parse(mojodi.Text);
            MessageBox.Show("Your information edited successfully.");


        }
    }
}
