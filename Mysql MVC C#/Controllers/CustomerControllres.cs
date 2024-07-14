using System;
using System.Collections.Generic;
using Mysql_MVC_C_.Models;
using Mysql_MVC_C_.Repository;

namespace Mysql_MVC_C_.Controllers
{
    public class CustomerControllers
    {
        private Repositorys repository;

        public CustomerControllers()
        {
            repository = new Repositorys();
        }

        public void AddCustomer(string name, string email)
        {
            Customer customer = new Customer
            {
                Name = name,
                Email = email
            };
            repository.CreateCustomer(customer);
        }

        public void ListCustomers()
        {
            List<Customer> customers = repository.GetAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine($"Nome: {customer.Name}, Email: {customer.Email}");
            }
        }
    }
}
