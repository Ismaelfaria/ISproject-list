using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class LoginVerification
    {
        public LoginVerification(string Name, string Pass)
        {
            List<UserModel> users = LoginVerification.MenagerUsers(UserDatabase._users, Name, Pass);

            if (users.Count == 0)
            {
                Console.WriteLine("Usuario não encontrado");
            }
            else
            {
                foreach (var item in users)
                {
                    Console.WriteLine($"Usuario encontrado\n" + "Cadastro\n" + $"Username: {item.UserName} Password: {item.UserPassword}");

                }
            }
        }
        public static List<UserModel> MenagerUsers(List<UserModel> dados, string user, string pass)
        {
            List<UserModel> verific = dados
                .Where(x => x.UserName == user && x.UserPassword == pass)
                .ToList();

            return verific;
        }
    }
}
