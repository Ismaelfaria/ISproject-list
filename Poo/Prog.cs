using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Prog
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario();
            usuario.Nome = "Davi";
            usuario.Buscar();
            Console.WriteLine(usuario.Nome); 
        }
    }
}
