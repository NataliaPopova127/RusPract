using Pract2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pract2.Core
{
    public class UserValidator
    {
        public bool Validate(User user, string login, string password)
        {
            int k = 0;
            if (user.Login == login && user.Password == password)
            {
                k++;
            }

            if (k > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
