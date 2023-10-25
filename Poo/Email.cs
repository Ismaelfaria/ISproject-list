using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Email
    {
        private Email() { }

        private static Email instancia;

        public static Email Instancia 
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            } 
        }
    }
}
