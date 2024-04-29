using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Aula008.data;
using Aula008.Models;
using Aula008.Repository;
using Aula008.Controllers;
using System.Runtime.InteropServices;

namespace Aula008.Views
{
    public class CostumerView

    {
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
                        costumer.Name.Add("paulo");
                        costumer.Name.Add("paulinho");
                        costumer.Name.Add("pauladas");
                        while (true)
                        {

                          Console.WriteLine("quer terminar ");
                          string terminar=Console.ReadLine();
                          if(terminar.Equals("s"))
                          {
                            break;
                          }
                          else
                          {
                          Console.WriteLine("inserir um elemento na lista de nomes");
                          string inserir=Console.ReadLine();
                          costumer.Name.Add(inserir);

                          }
                        }
                        break;
                        case 2:

                           
                             Console.WriteLine("insere as  as letras inicial para a pesquisa do nome \n  no minimo quatro letras  : ");
                            string nomeBusca=Console.ReadLine();
                            
                                if(nomeBusca.Length>0 && nomeBusca.Length<=4)
                                {
                                    List<string> resultados = costumer.BuscarPorNome(costumer.Name, nomeBusca);

                                    if (resultados.Count > 0)
                                    {
                                        Console.WriteLine("Resultados encontrados:");
                                        foreach (var nome in resultados)
                                        {
                                            Console.WriteLine(nome);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nenhum resultado encontrado.");
                                    }
        
                                    break; 
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Os dados inserir não obdecem as condições ");
                                    Console.WriteLine("Repeti novamente ");
                                    Console.WriteLine();
                                }
                            


                                Console.WriteLine("");
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