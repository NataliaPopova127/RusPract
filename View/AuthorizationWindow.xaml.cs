using Pract2.Core;
using Pract2.Models;
using System;
using System.Collections.Generic;
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

            _usersList = new List<User>();
            _usersList.Add(new User("sama", "samasama", "Самира", "Тугуз", "Сальбиевна"));
            _usersList.Add(new User("nata", "natanata", "Наталья", "Попова", "Максимовна"));
            _usersList.Add(new User("art", "artart", "Артем", "Дудка", "Духовой"));
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            foreach(var list in _usersList)
            {
                if (new UserValidator().Validate(list))
                {
                    new DashboardWindow().Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    break;
                }
            }
            
        }
    }
}
