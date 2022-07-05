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
    /// Interaction logic for UserDashboard.xaml
    /// </summary>
    public partial class UserDashboard : Window
    {
        User obj;
        public UserDashboard(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void open_userprofile(object sender, RoutedEventArgs e)
        {
            userprofile userprofile = new userprofile(obj);
            userprofile.Show();
            this.Close();
        }
    }
}
