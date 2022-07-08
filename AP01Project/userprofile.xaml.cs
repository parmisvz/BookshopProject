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
using System.Data;
using System.Data.SqlClient;

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
            username.Text = "password: " + obj.password;
            name.Text = "Name: " + obj.name;
            phone.Text = "Phone: " + obj.phone_number;
           
        }

        private void edit_userinfo(object sender, RoutedEventArgs e)
        {
            try
            {


                obj.password = username.Text;
                obj.name = name.Text;
                obj.phone_number = phone.Text;
               
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30");
                //SqlDataAdapter adapter = new SqlDataAdapter();
                //SqlCommand command = new SqlCommand();
                //command.CommandText="UPDATE TUserInfo SET name = @command where user_name"
                //adapter.UpdateCommand = command;
                //adapter.UpdateCommand.Parameters.Add("@command",SqlDbType.NVarChar).Value
                //string command;
                //command = "UPDATE TUserInfo SET user_name='" + username.Text + "',name='" + name.Text + "',phone_number='" + phone.Text + "' WHERE password='" + obj.password + "'     ";
                //SqlCommand com = new SqlCommand(command, con);
                //com.BeginExecuteNonQuery();
                //con.Close();


                MessageBox.Show("Your information edited successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
