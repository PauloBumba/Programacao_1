using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Views
{
    public class CostumerView
    {
        public  bool aux =true;
        public void init()
        {
            Console.WriteLine("Menu Customer");
            Console.WriteLine("**************");
           
           do
           {
            Console.WriteLine("Escolha uma opção :");
            Console.WriteLine("1-- Inseir consumidor ");
            Console.WriteLine("2--pesquisar consunmidor ");
            Console.WriteLine("listar Consumidores ");
            Console.WriteLine("0 sair");
            int menu =0;

            try
            {
                 switch(menu)
                 {
                    case 0:
                            aux=false;
                            break;
                    case 1:
                            aux=false;
                            break;
                    case 2:
                            aux=false;
                            break;
                    case 3:
                            aux=false;
                            break;
                    default :
                        Console.WriteLine("opção invalida");
                        aux=true;
                             break;
            }
            catch
            {
                Console.WriteLine("opção invalida");
                menu=-1;
            }

           } while (aux);
        }
    }
}
}