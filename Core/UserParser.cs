using Pract2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pract2.Core
{
    public class UserParser
    {
        public static IEnumerable<User> Parse(string path)
        {
            foreach(var lines in File.ReadAllLines(path).Skip(1))
            {
                var props = lines.Split(';');
                yield return new User(Convert.ToInt32(props[0]), props[1], props[2], props[3], Convert.ToDateTime(props[4]), Convert.ToDecimal(props[5]), props[6], props[7], props[8]);
            }
        }
    }
}
