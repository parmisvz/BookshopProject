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
                int discount = 0;
                for (int i = 0; i < obj.Library.Count; i++)
                {
                    sum += obj.Library[i].Price;
                    discount+=obj.Library[i].Discount;
                }
                if (sum <= obj.mojodi)
                {
                    sum = sum - (sum * discount / 100);
                    obj.mojodi -= sum;
                    
                    String ee = obj.user_name;

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30");
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

                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\erare\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30");
                    con2.Open();
                    string command2 = "INSERT INTO TUserInfo (user_name,password,name,phone_number,mojodi,bought,bookmark) values('" + obj.user_name + "','" + obj.password + "','" + obj.name + "','" + obj.phone_number + "','" + obj.mojodi + "','" + obj.savedbooks + "','"+obj.bookmark+"')";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(command2, con2);

                    adapter.InsertCommand.ExecuteNonQuery();
                    con2.Close();
                    shop.mojodi += sum;
                    MessageBox.Show("Thanks for your shop.");
                    obj.savedbooks = "";
                    for (int i = 0; i < obj.Library.Count; i++)
                    {
                        obj.bought.Add(obj.Library[i]);
                        if (obj.savedbooks == "")
                        {
                            obj.savedbooks += obj.Library[i].Id;

                        }
                        else
                        {
                            obj.savedbooks += "," + obj.Library[i].Id;
                        }
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
