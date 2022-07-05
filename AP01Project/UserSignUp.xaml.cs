using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AP01Project
{
    /// <summary>
    /// Interaction logic for UserSignUp.xaml
    /// </summary>
    public partial class UserSignUp : Window
    {
        public UserSignUp()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMousedown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void show_signin(object sender, RoutedEventArgs e)
        {
            try
            {
                string khata = "";
                string pattern = @"^[09][0-9]{9}";

                if (pass.Password != password.Password)
                {
                    khata += "Passwords doesnt match.\n";
                }
                if (pass.Password == "" || password.Password == "" || username.Text == "" || name.Text == "" || phone.Text == "")
                {
                    khata += "Please fill all the fields.\n";
                }
                if (!Regex.IsMatch(phone.Text, pattern))
                {
                    khata += "Your phone number is not valid.\n";
                }
                if (name.Text.Length < 3 || name.Text.Length > 32 || !Regex.IsMatch(name.Text, @"[a-zA-Z]"))
                {
                    khata += "Name is not valid.\n";
                }
                if (!Regex.IsMatch(username.Text, @"^([\w\.\-]{1,32})@([\w\-]{1,32})((\.(\w){1,32})+)$"))
                {
                    khata += "Email is not valid.\n";
                }
                if (!Regex.IsMatch(pass.Password, @"^(?=.*?[A-Z])(?=.*?[a-z]).{8,40}"))
                {
                    khata += "Password is not valid.\n";
                }
                if (khata != "")
                {
                    throw new Exception(khata);
                }
                else
                {
                    User cust = new User(username.Text, pass.Password, name.Text, phone.Text);
                    User.addtousers(cust, username.Text);
                    UserSignIn window1 = new UserSignIn();
                    window1.Show();
                    // user.checkusers(cust);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}

