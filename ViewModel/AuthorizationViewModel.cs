using Pract2.Command;
using Pract2.Core;
using Pract2.Models;
using Pract2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Pract2.ViewModel
{
    class AuthorizationViewModel : BaseViewModel
    {
        private string _login;
        private string _password;
        public string Login { get => _login; set => SetProperty(ref _login, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public ICommand SignInCommand { get; private set; }
        public AuthorizationViewModel()
        {
            SignInCommand = new DelegateCommand(SignIn);
        }
        private void SignIn(object parameter)
        {
            List<User> UsersList = UserParser.Parse("users3.txt").ToList();
            UserValidator userValidator = new UserValidator();
            if (userValidator.ValidateLoginAndPassword(UsersList, Login, Password))
            {
                if (userValidator.ValidateRole(userValidator.CurrentUser) == 1)
                {
                    new ClientWindow().Show();
                    Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w is AuthorizationWindow).Close();
                }
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 2)
                {
                    new AdminWindow().Show();
                    Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w is AuthorizationWindow).Close();
                }
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 3)
                {
                    new ManagerWindow().Show();
                    Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w is AuthorizationWindow).Close();
                }
                else if (userValidator.ValidateRole(userValidator.CurrentUser) == 0)
                    MessageBox.Show("Неизвестная роль"); 
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
