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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void open_windowuser(object sender, RoutedEventArgs e)
        {

            UserChoose thirdwindow = new UserChoose();
            thirdwindow.Show();
            this.Close();
        }
        private void open_windowadmin(object sender, RoutedEventArgs e)
        {
            AdminChoose window5 = new AdminChoose();
            window5.Show();
            this.Close();

        }
    }

}


