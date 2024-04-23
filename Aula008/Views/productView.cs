using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Views
{
    public class productView
    {
        public productView()
        {
            this.init();
        }
        public void init()
        {
            Console.WriteLine("MENU PEDIDOS");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir  produtos");
                Console.WriteLine("2 - Pesquisar   produtos");
                Console.WriteLine("3 - Listar   produtos");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3: 
                        break;
                        default: 
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
    }
}
    }
