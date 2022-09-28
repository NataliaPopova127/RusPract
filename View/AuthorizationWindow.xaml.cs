using Pract2.Core;
using Pract2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pract2.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private List<User> _usersList;
        public AuthorizationWindow()
        {
            InitializeComponent();

            _usersList = UserParser.Parse("users3.txt").ToList();
           // MessageBox.Show(users[5].ToString());
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            bool valid = false;
            foreach(var list in _usersList)
            {
                if (new UserValidator().Validate(list, tbLogin.Text, tbPassword.Password))
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
            {
                new DashboardWindow().Show();
            }
            else MessageBox.Show("Неверный логин или пароль");
            
        }
    }
}
