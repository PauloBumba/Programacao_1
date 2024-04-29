using System;
using  Aula008.Views;
using Aula008.Models;
using Aula008.data;
using Aula008.Repository;

bool aux = true;
do{
    Console.WriteLine("**********************");
    Console.WriteLine("MEU POGRAMA DE PIDIDUX");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - SAIR");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                
               CostumerView  costumerView = new CostumerView();
            break;
            
            case 2:
              productView productViewv = new productView();
            break;

            case 3:
            pedidosview pedidosview= new pedidosview();
            break;

            case 0:
                aux = false;
                Console.WriteLine("Obrigado e volte sempre!");
            break;

            default:
                Console.WriteLine("Opção inválida.");                         
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida.");
        menu = -1;
        aux = true;
    }

}while(aux);
