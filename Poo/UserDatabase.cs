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
            new UserModel{Id = 1, UserName = "Alex", UserPassword = "12345"},
            new UserModel{Id = 2, UserName = "Davi", UserPassword = "12345"},
            new UserModel{Id = 3, UserName = "Daniel", UserPassword = "12345"},
            new UserModel{Id = 4, UserName = "Roberto", UserPassword = "12345"}
        };
    }
}
