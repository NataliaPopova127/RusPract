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
        public static List<User> usersList;
        public AuthorizationWindow()
        {
            InitializeComponent();
            usersList = UserParser.Parse("users3.txt").ToList();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserValidator userValidator = new UserValidator();
                if (userValidator.ValidateLoginAndPassword(usersList, tbLogin.Text, tbPassword.Password))
                {
                    //if (userValidator.ValidateRole(userValidator.CurrentUser) == 1)
                    //    new ClientWindow().Show();
                    //else if (userValidator.ValidateRole(userValidator.CurrentUser) == 2)
                    //    new AdminWindow().Show();
                    //else if (userValidator.ValidateRole(userValidator.CurrentUser) == 3)
                    //    new ManagerWindow().Show();
                    //else if (userValidator.ValidateRole(userValidator.CurrentUser) == 0)
                    //    MessageBox.Show("Неизвестная роль");
                    new DashboardWindow().Show();
                    Close();
                }
                else MessageBox.Show("Неверный логин или пароль");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
