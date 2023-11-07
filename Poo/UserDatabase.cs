using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class UserDatabase
    {
        public static List<UserModel> _users = new()
        {
            new UserModel( 1,  "Alex",  "12345"),
            new UserModel( 2,  "Davi", "12345" ),
            new UserModel(3, "Daniel", "12345"),
            new UserModel(4, "Roberto", "12345")
        };
    }
}
