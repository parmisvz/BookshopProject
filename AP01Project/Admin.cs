using System;
using System.Collections.Generic;
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
            this.user_name = user_name;
            this.password = password;
            this.name = name;
            this.phone_number = phone_number;
           // Admins.Add(this);           
        }
        public static  string Name(string user_name)
        {
            int j = 0;
            for(int i=0;i<Admins.Count;i++)
            {
                if(Admins[i].user_name == user_name)
                {
                    return Admins[i].name;
                }
                else
                {
                    j++;
                }
            }
            if (j == Admins.Count)
            {
                return "";
            }
            else
            {
                return "";
            }
        }
        public static string Phone_number(string user_name)
        {
            for (int i = 0; i < Admins.Count; i++)
            {
                if (Admins[i].user_name == user_name)
                {
                    string x = Admins[i].phone_number;
                    return x;
                }
            }
            return null;
        }
        public static bool check_username(string user_name)
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
            Admins=ReadFromSQLAddToList();
            bool accept = false;
            for (int i = 0; i < Admins.Count; i++)
                if (Admins[i].user_name == username)
                    accept = (Admins[i].password == pass) ? true : false;

            if (Admins.Count == 0)
                accept = false;

            return accept;
        }
        public static List<Admin> ReadFromSQLAddToList()
        {
            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\AP01Project\data\AdminInfo.mdf;Integrated Security=True;Connect Timeout=30";
            //string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\AdminInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathZahra);
            string Command = "select * from TAdminInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            List<Admin> list = new List<Admin>();
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                Admin temoAdmin = new Admin(dataT.Rows[i][0].ToString(), dataT.Rows[i][2].ToString(), dataT.Rows[i][1].ToString(), dataT.Rows[i][3].ToString());
                list.Add(temoAdmin);
            }
            return list;
        }
    }
}

