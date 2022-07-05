using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP01Project
{
    public class Admin
    {
        public static List<Admin> Admins = new List<Admin>();
        public string user_name { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
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
            int j = 0;
            for (int i = 0; i < Admins.Count; i++)
            {
                if (username == Admins[i].user_name)
                {
                    if (pass == Admins[i].password)
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
            if (j == Admins.Count)
            {
                return false;
            }
            else return true;
        }
    }
}

