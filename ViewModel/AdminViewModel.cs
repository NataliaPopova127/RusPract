using Pract2.Command;
using Pract2.Core;
using Pract2.Models;
using Pract2.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Pract2.ViewModel
{
    class AdminViewModel : BaseViewModel
    {
        private Page _selectedPage;
        public static List<User> UsersList { get; set; }
        public Page SelectedPage { get => _selectedPage;
            set => SetProperty(ref _selectedPage, value); }
        public ICommand OpenClientPageCommand { get; private set; }
        public ICommand OpenManagerPageCommand { get; private set; }
        public ICommand OpenAdminPageCommand { get; private set; }
        public AdminViewModel()
        {
            UsersList = UserParser.Parse("users3.txt").ToList();
            OpenClientPageCommand = new DelegateCommand(OpenUsersPage);
            OpenAdminPageCommand = new DelegateCommand(OpenAdminPage);
            OpenManagerPageCommand = new DelegateCommand(OpenManagerPage);
        }
        private void OpenUsersPage(object parametr)
        {
            SelectedPage = new ClientPage();
        }
        private void OpenManagerPage(object parametr)
        {
            SelectedPage = new ManagerPage();
        }
        private void OpenAdminPage(object parametr)
        {
            SelectedPage = new AdminPage();
        }
    }
}
