using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {                
        public void Create(Customer customer)
        {
            customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }

        public Customer Reed(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )                
                    return c;                
            }

            return null;
        }

        public List<Customer> Reed()
        {
            return DataSet.Customers;
        }

        public List<Customer> ReedByName(string name)
        {
            List<Customer> retorno = new List<Customer>();
            foreach(var c in DataSet.Customers)
            {
                if(c.Name.Contains(name))
                {
                    retorno.Add(c);
                }
            }

            return retorno;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerId > n)                
                    n = c.CustomerId;
            }

            return ++n;
        }   
        public void Update(Customer updatedCustomer)
        {
            try {
                 var existingCustomer = Reed(updatedCustomer.CustomerId);
                    if (existingCustomer != null)
                    {
                        existingCustomer.Name = updatedCustomer.Name;
                        existingCustomer.Addresses = updatedCustomer.Addresses;

                     }
      
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("os Dados foram atualizados com sucessos");
            }
     
        }
        public void DeleteById(int customerId)
        {
            try
            {
                var existingCustomer = Reed(customerId);
                if (existingCustomer != null)
                {
                    DataSet.Customers.Remove(existingCustomer);
                // Lembre-se de salvar as alterações (se necessário)
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Update(int id, string newName)
        {
            // Verifica se existe algum cliente com o ID especificado
            bool customerExists = Data.DataSet.Customers.Any(c => c.CustomerId == id);

            if (customerExists)
            {
                // Encontra o cliente com o ID correspondente
                Customer customerToUpdate = Data.DataSet.Customers.First(c => c.CustomerId == id);

                // Atualiza o nome do cliente
                customerToUpdate.Name = newName;

                Console.WriteLine($"Nome do cliente com ID {id} atualizado para: {newName}");
            }
            else
            {
                Console.WriteLine($"Ops! Ocorreu um erro ao atualizar o cliente de ID {id}. Cliente não encontrado.");
            }
        }


    }
}