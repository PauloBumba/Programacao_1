using System;
using Mysql_MVC_C_.Controllers;

namespace Mysql_MVC_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerControllers customerControllers = new CustomerControllers();

            Console.WriteLine("Digite o nome do cliente:");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o email do cliente:");
            string email = Console.ReadLine();

            customerControllers.AddCustomer(name, email);
            Console.WriteLine("Cliente criado com sucesso.");

            Console.WriteLine("Lista de clientes:");
            customerControllers.ListCustomers();
        }
    }
}
