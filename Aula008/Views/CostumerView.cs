using System;
using System.Collections.Generic;
using System.Linq;

using Aula008.;
using Aula008.Models;
using Aula008.Re;
using Aula008.Views;



namespace Aula008.Views
{
    public class CostumerView

    {
        public 
        private CustomerControllers customerControllers;
        Custemer costumer=new Custemer();
        public CostumerView()
        {
            this.init();
        }
        public void init()
        {
            Console.WriteLine("MENU CUSTOMER");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
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