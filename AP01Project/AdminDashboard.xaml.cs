using System;
using System.Collections.Generic;
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
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        Admin obj;
        public AdminDashboard(Admin _obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void ShowInformation(object sender, RoutedEventArgs e)
        {
            obj.user_name = username.Text;
            obj.name = name.Text;
            obj.phone_number = phone.Text;
        }

        private void Edit(object sender, RoutedEventArgs e)
        {

        }
    }
}

