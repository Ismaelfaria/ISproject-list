using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class or
    {
        static void Main()
        {
            List<Bd> dados = new List<Bd>
        {
            new Bd { usuario = "JonhKenedy", senha = 12345678 },
            new Bd { usuario = "GermanCano", senha = 123456789 }
        };

            List<Bd> resultado = ManagerList(dados, "JonhKenedy");

            if(resultado.Count == 0)
            {
                Console.WriteLine("Usuario não encontrado");
            }
            else { 
            // Agora você pode fazer algo com a lista resultado.
                foreach (var item in resultado)
                {
                    Console.WriteLine($"Usuário: {item.usuario}, Senha: {item.senha}");
                }
            }
        }

        static List<Bd> ManagerList(List<Bd> dados, string nome)
        {
            List<Bd> bds = dados
                .Where(x => x.usuario == nome)
                .ToList();

            return bds; // Retornar a lista para uso posterior.
        }
    }

}


public class Bd()
{
    public string usuario { get; set; }
    public int senha { get; set; }
}
