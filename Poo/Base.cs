using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Base
    {
        public string Nome { get ; set ; }
        public string Cpf { get ; set ; }

        public void Buscar()
        {
            Console.WriteLine("O meu nome é "+Nome);
        }
        public void Ler()
        {
            Console.WriteLine(Cpf);
        }

    }
}
