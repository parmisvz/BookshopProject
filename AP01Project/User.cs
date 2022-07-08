using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AP01Project
{
    public class User
    {
        public static List<User> Users = new List<User>();
        public static List<User> VIPUsers = new List<User>();
        public List<Book> Library = new List<Book>();
        public List<Book> bought = new List<Book>();
        public List <Book> bookmark = new List<Book>();
        public List<Book> VIPBook = new List<Book>();
        public string savedbooks { get; set; }
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


            this.user_name = user_name;
            this.password = password;
            this.name = name;
            this.phone_number = phone_number;
            this.mojodi = 0;


        }
        public static void addtousers(User obj, string user_name)
        {




            Users.Add(obj);

        }
        public static string Name(string user_name)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].user_name == user_name)
                {
                    string x = Users[i].name;
                    return x;
                }
            }
            return null;
        }
        public static string Phone_number(string user_name)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].user_name == user_name)
                {
                    string x = Users[i].phone_number;
                    return x;
                }

            }
            return null;
        }
        public static bool check_username(string user_name)
        {
            int j = 0;
            for (int i = 0; i < Users.Count; i++)
            {
                if (user_name == Users[i].user_name)
                {
                    return true;
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
            else
            {
                return true;
            }
        }
        
        public static bool checkuser(string username, string pass)
        {
            Users = Readfromsqltolist();
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

        public static List<User> Readfromsqltolist()
        {
            string pathZahra = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
           // string pathParmis = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Desktop\ProjectFile\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(pathZahra);
            string Command = "select * from TUserInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            List<User> list = new List<User>();
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                User temoAdmin = new User(dataT.Rows[i][0].ToString(), dataT.Rows[i][1].ToString(), dataT.Rows[i][2].ToString(), dataT.Rows[i][3].ToString());
                list.Add(temoAdmin);
            }
            return list;
        }
        public static bool tekrarinabodan(string username)
        {
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\parmisproject\BookshopProject\AP01Project\data\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(path);
            string Command = "select * from TUserInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(Command, sqlConnection);
            DataTable dataT = new DataTable();
            adapter.Fill(dataT);
            int j = 0;
            for (int i = 0; i < dataT.Rows.Count; i++)
            {
                if (dataT.Rows[i][0].ToString() == username)
                {
                    return false;
                }
                else
                {
                    j++;
                }
            }
            if (j == dataT.Rows.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static long SumOfDigits(long number)
            {
                long sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }
            public static bool LuhnCheck(long number)
            {
                List<long> digits = new List<long>();
                while (number > 0)
                {
                    digits.Add(number % 10);
                    number /= 10;
                }
                for (int i = 0; i < digits.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        digits[i] = SumOfDigits(digits[i] *= 2);
                    }
                }
                long value = digits.Sum();
                return value % 10 == 0 ? true : false;
            }
        }
    }

