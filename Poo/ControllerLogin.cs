using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POO
{
    internal class ControllerLogin
    {
        public ControllerLogin(int Id, string Name, string Pass)
        {
            List<UserModel> addUsers = ControllerLogin.AddUsers(UserDatabase._users, Id, Name, Pass);

            if (addUsers != null)
            {
                Console.WriteLine("SUCESSO: Usuario Adicionado\n");
            }
            else
            {
                Console.WriteLine("ERRO: Usuario não Adicionado, Usuario já existe");
            }
        }
        public static List<UserModel> AddUsers(List<UserModel> dados, int id, string user, string pass)
        {
            bool usuarioExistente = dados.Any(x => x.UserName == user);


            if (usuarioExistente != true)
            {
                UserModel novoUsuario = new UserModel
                {
                    Id = id,
                    UserName = user,
                    UserPassword = pass
                };

                var add = dados
                    .Concat(new List<UserModel> { novoUsuario })
                    .ToList();

                Console.WriteLine("Usuario");

                foreach (var item in add)
                {
                    Console.WriteLine($"-- Id: {item.Id}  |  Username: {item.UserName}");
                }

                return add;
            }
            else
            {
                return null;
            }
        }



        public ControllerLogin(string name)
        {

            List<UserModel> usersConsult = ControllerLogin.ConsultUsers(UserDatabase._users, name);

            if (usersConsult.Count == 0)
            {
                Console.WriteLine("Usuario não encontrado");
            }
            else
            {
                foreach (var item in usersConsult)
                {
                    Console.WriteLine($"Usuario encontrado\n" + "Cadastro\n" + $"Id: {item.Id}  |  Username: {item.UserName}");
                }
            }
        }
        public static List<UserModel> ConsultUsers(List<UserModel> dados, string user)
        {
            List<UserModel> verific = dados
                .Where(x => x.UserName == user)
                .ToList();


            return verific;
        }
    }

}

