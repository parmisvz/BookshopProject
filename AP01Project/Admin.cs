using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AP01Project
{
    public class Admin
    {
        public static List<Admin> Admins = new List<Admin>();
        public string user_name { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public int AccountBalance { get; set; }

        public Admin(string user_name, string password, string name, string phone_number)
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
                Admins.Add(this);
            }
        }
        public bool check_username(string user_name)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (user_name == Admins[i].user_name)
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
        public static bool checkadmin(string username, string pass)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\AdminInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(path);
            string Command = "select * from TAdminInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            if (dataT.Rows.Count != 0)
                return true;
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                Console.WriteLine(dataT.Rows[i][0]);
                Console.WriteLine(dataT.Rows[i][2]);
                if (dataT.Rows[i][0]== username)
                {
                    if (dataT.Rows[i][2]== pass)
                        return true;
                    else
                        return false;
                }
            }
            return false;
            
        }
    }
}

