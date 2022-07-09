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

                string ee = obj.user_name;
                SqlConnection con=new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf; Integrated Security = True; Connect Timeout = 30");
                SqlDataAdapter vv = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM TUserInfo where user_name=@ee";
                vv.DeleteCommand = cmd; 
                vv.DeleteCommand.Parameters.Add("@ee",SqlDbType.NVarChar).Value=obj.user_name;
                vv.DeleteCommand.Connection = con;
                con.Open();
                vv.DeleteCommand.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\AP\BookshopProject\AP01Project\data\BookInfo.mdf;Integrated Security=True;Connect Timeout=30";
                //string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";                
                SqlConnection con2 = new SqlConnection(pathZahra);
                con2.Open();
                string command2 = "INSERT INTO TUserInfo (user_name,password,name,phone_number,mojodi,bought) values('" + obj.user_name + "','" + obj.password + "','" + obj.name + "','" + obj.phone_number + "','" + obj.mojodi + "','" + obj.savedbooks + "')";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(command2, con2);

                adapter.InsertCommand.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Your information edited successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void back(object sender, RoutedEventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard(obj);
            userDashboard.Show();
            this.Close();
        }
    }
}
