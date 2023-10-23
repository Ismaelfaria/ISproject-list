using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
     interface IPessoas
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public void Buscar();
        public void Ler();
    }
}
