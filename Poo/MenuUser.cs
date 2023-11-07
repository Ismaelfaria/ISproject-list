using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class MenuUser
    {
        public static void start()
        {

            int resp;

            do
            {

                string titulo = "\n=====MENU=====\n" + "\n====Opções a seguir:====\n" +
                    "\n- 1 - EXIT THE PROGRAM\n" + "\n- 1 - CREATE USER\n" + "\n- 2 - REMOVE USER\n" + "\n- 3 - READ USER\n" + $"\n==DIGITE A OPÇÃO: ==";

                Console.WriteLine(titulo);

                resp = int.Parse(Console.ReadLine());

                try
                {
                    if (resp == (int)EnumOptions.CREATE)
                    {
                        Console.WriteLine("\n CRIANDO UM USUARIO\n");
                        Console.WriteLine(" - ID:");
                        int respId = int.Parse(Console.ReadLine());
                        Console.WriteLine(" - NOME:");
                        string respNome = Console.ReadLine();
                        Console.WriteLine(" - PASS:");
                        string respPass = Console.ReadLine();

                        var addFuncion = new ControllerLogin(respId, respNome, respPass);

                    }
                    else if (resp == (int)EnumOptions.REMOVE)
                    {
                        Console.WriteLine("\n REMOVENDO UM USUARIO\n");
                        Console.WriteLine(" - NOME:");
                        string respNome = Console.ReadLine();
                        Console.WriteLine(" - PASS:");
                        string respPass = Console.ReadLine();

                        var removeFuncion = new ControllerLogin(respNome, respPass);

                    }
                    else if (resp == (int)EnumOptions.READ)
                    {
                        Console.WriteLine("===== CADASTROS DE USUARIO =====");
                        var readFuncion = new ControllerLogin();

                    }
                    Console.WriteLine("=================================");
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("========= FormatException ========");
                    Console.WriteLine("Verifique se vc adicionou todos os itens === " + ex.Message);
                    Console.WriteLine("==================================");
                }
            } while (resp != 0);
        }
    }
}

