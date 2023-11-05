using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class UserDatabase : UserModel
    {
        public static List<UserModel> _users = new()
        {
            new UserModel{ UserName = "Alex", UserPassword = "12345"},
            new UserModel{ UserName = "Davi", UserPassword = "12345"},
            new UserModel{ UserName = "Daniel", UserPassword = "12345"},
            new UserModel{ UserName = "Roberto", UserPassword = "12345"}
        };
    }
}
