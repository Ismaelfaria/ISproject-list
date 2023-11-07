using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class UserModel
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public UserModel(int id, string userName, string userPassword)
        {
            Id = id;
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            UserPassword = userPassword ?? throw new ArgumentNullException(nameof(userPassword));
        }
    }
}
