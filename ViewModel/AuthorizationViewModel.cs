using Pract2.Core;
using Pract2.View;
using System;
using System.Collections.Generic;
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

        }
        private void SignIn(object parameter)
        {
            UserValidator userValidator = new UserValidator();
            if (userValidator.ValidateLoginAndPassword(AuthorizationWindow.UsersList, Login, Password))
            {
                new DashboardWindow().Show();
            }
            else MessageBox.Show("Неверный логин или пароль");
        }
    }
}
