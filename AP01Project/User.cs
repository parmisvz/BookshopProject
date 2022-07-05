using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AP01Project
{
    public class User
    {
        public static List<User> Users = new List<User>();
        public static List<User> VIPUsers = new List<User>();
        public List<Book> Library = new List<Book>();
        public List<Book> VIPBook=new List<Book>();
        public string user_name { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public int mojodi { get; set; }
        public bool PremiumMembership { get; set; }
        public int PremiumMembershipDate { get; set; }
        public ShoppingCart CustomerCart { get; set; }
        public User(string user_name, string password, string name, string phone_number)
        {
            if (!check_username(user_name))
            {
                throw new Exception("username is not valid");
            }
            else
            {
                this.user_name = user_name;
                this.password = password;
                this.name = name;
                this.phone_number = phone_number;
                this.mojodi = 0;
                Users.Add(this);
                sqladd();
            }
        }
        public bool check_username(string user_name)
        {

            for (int i = 0; i < Users.Count; i++)
            {
                if (user_name == Users[i].user_name)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }
        public void sqladd()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\WpfApp1\data\user2.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string command;
            command = "insert into Table values('" + user_name + "','" + password + "', '" + name + "','" + phone_number + "','" + mojodi + "')";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.BeginExecuteNonQuery();
            // new
            // conn.Close();
        }
        public static bool checkuser(string username, string pass)
        {
            int j = 0;
            for (int i = 0; i < Users.Count; i++)
            {
                if (username == Users[i].user_name)
                {
                    if (pass == Users[i].password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    j++;
                }
            }
            if (j == Users.Count)
            {
                return false;
            }
            else return true;
        }
        //public void checkusers(user obj)

    }
}
