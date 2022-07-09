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
    /// Interaction logic for increasemojodi.xaml
    /// </summary>
    public partial class increasemojodi : Window
    {
        User obj;
        public increasemojodi(User obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void price(object sender, RoutedEventArgs e)
        {
            total.Text = "account balance: " + obj.mojodi;
        }
        private void Buy(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = 0, b = 0;
                if (!User.LuhnCheck(Int64.Parse(CardNo.Text)))
                {
                    throw new Exception("Invalid Card no");
                }
                else
                {
                    a = 1;
                }
                if (int.Parse(CVV2.Text) < 10 || int.Parse(CVV2.Text) >= 1000)
                {
                    throw new Exception("Invalid cvv2");
                }
                else
                {
                    b = 1;
                }
                if (a == 1 && b == 1)
                {
                    obj.mojodi+=int.Parse(money.Text);
                    
                    String ee = obj.user_name;

                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf; Integrated Security = True; Connect Timeout = 30");
                    SqlDataAdapter vv = new SqlDataAdapter();
                    SqlCommand pp = new SqlCommand();
                    pp.CommandText = "DELETE FROM TUserInfo where user_name=@ee";
                    vv.DeleteCommand = pp;
                    vv.DeleteCommand.Parameters.Add("@ee", SqlDbType.NVarChar).Value = obj.user_name;
                    vv.DeleteCommand.Connection = con;
                    con.Open();
                    vv.DeleteCommand.ExecuteNonQuery();
                    con.Dispose();
                    con.Close();

                    SqlConnection con2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf; Integrated Security = True; Connect Timeout = 30");
                    con2.Open();
                    string command2 = "INSERT INTO TUserInfo (user_name,password,name,phone_number,mojodi,bought) values('" + obj.user_name + "','" + obj.password + "','" + obj.name + "','" + obj.phone_number + "','" + obj.mojodi + "','" + obj.savedbooks + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(command2, con2);

                    adapter.InsertCommand.ExecuteNonQuery();
                    con2.Close();
                    MessageBox.Show("Your account balance increased");
                    for (int i = 0; i < obj.Library.Count; i++)
                    {
                        obj.bought.Add(obj.Library[i]);
                    }
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
    }
}
