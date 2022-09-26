using System;
using System.Collections.Generic;
using System.Text;

namespace Pract2.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User()
        {
            Login = string.Empty;
            Password = string.Empty;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
        }
        public User(string login, string password, string firstName, string middleName, string lastName)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
