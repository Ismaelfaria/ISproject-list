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

        /// <summary>
        /// Add information to the database.
        /// </summary>
        public ControllerLogin(int Id, string Name, string Pass)
        {
            List<UserModel> addUsers = ControllerLogin.AddUsers(UserDatabase._users, Id, Name, Pass);

            if (addUsers != null)
            {
                Console.WriteLine("SUCESSO: Usuario Adicionado\n");
            }
            else
            {
                Console.WriteLine("ERRO: Usuario não Adicionado, Usuario já existe ou Posição já ocupada");
            }
        }
        private static List<UserModel> AddUsers(List<UserModel> dados, int id, string user, string pass)
        {
            var usuarioExistente = dados.Any(x => x.UserName == user || x.Id == id);

            if (usuarioExistente != true)
            {
                UserModel novoUsuario = new UserModel
                (
                   default,
                   user,
                   pass
                );
                dados.Add(novoUsuario);

                return dados;
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// Remove information to the database.
        /// </summary>
        public ControllerLogin(string Name, string Pass)
        {
            List<UserModel> removeUsers = ControllerLogin.RemoveUsers(UserDatabase._users, Name, Pass);

            if (removeUsers != null)
            {
                Console.WriteLine("SUCESSO: Usuario Removido\n");
            }
            else
            {
                Console.WriteLine("ERRO: Usuario não removido, Usuario não existe");
            }

        }
        private static List<UserModel> RemoveUsers(List<UserModel> dados, string user, string pass)
        {
            var usuarioExistente = dados.Any(x => x.UserName == user);

            if (usuarioExistente == true)
            {
                UserModel removerUsuario = new UserModel
                (
                   default,
                   user,
                   pass
                );

                var removeUser = dados
                    .RemoveAll(x => x.UserName == user && x.UserPassword == pass);

                return dados;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Query the database.
        /// </summary>
        public ControllerLogin()
        {
            List<UserModel> consultUsers = ControllerLogin.ConsultUsers(UserDatabase._users);

            if(consultUsers == null)
            {
                Console.WriteLine("Erro: não existe usuarios");
            }
        }
        private static List<UserModel> ConsultUsers(List<UserModel> dados)
        {
            List<UserModel> verific = dados
                .OrderBy(x => x.Id)
                .ToList();

            foreach (var item in verific)
            {  
                Console.WriteLine($"Id: {item.Id} | Nome: {item.UserName}");
            }
            return verific;
        }
    }
}

