using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Repository;
using _240401_01.Data;

namespace _240401_01.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public void Insert(Customer customer)
        {
            customerRepository.Create(customer);
        }

        public Customer Get(int id)
        {            
            return customerRepository.Reed(id);
        }

        public List<Customer> Get()
        {
            return customerRepository.Reed();
        }

        public List<Customer> GetByName(string name)
        {
            return customerRepository.ReedByName(name);
        }
        public void Delete(int id)
        {
            var  customerToRemove = Data.DataSet.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customerToRemove != null)
            {
                Data.DataSet.Customers.Remove(customerToRemove);
            
                Console.WriteLine("Consumidor removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Ops! Ocorreu um erro ao remover o consumidor de id {id}.");
            }

        }
        
       

   
  

   
}


    
    }
