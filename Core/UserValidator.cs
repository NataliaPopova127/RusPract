using Pract2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pract2.Core
{
    public class UserValidator
    {
        public bool Validate(User user)
        {
            int k = 0;
            if (user.Login == user.Login && user.Password == user.Password)
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
