using Pract2.Core;
using Pract2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pract2.ViewModel
{
    class UsersCollectionViewModel : BaseViewModel
    {
        private ObservableCollection<User> _user;
        public ObservableCollection<User> Users { get => _user; set => SetProperty(ref _user, value); }
        public UsersCollectionViewModel()
        {
            Users = new ObservableCollection<User>(UserParser.Parse("users3.txt"));
        }
    }
}
