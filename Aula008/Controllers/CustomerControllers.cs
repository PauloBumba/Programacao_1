using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
using Aula008.Repository;
using Aula008.Views;
using Aula008.data;
namespace Aula008.Controllers
{
    public class CustomerControllers
    {
      
            private CustomerRepository customerRepository;
            public CustomerControllers()
            {
                customerRepository = new CustomerRepository();
            }

            public void Insert(Custemer costumer)
            {
                customerRepository.Save(costumer);
            }
          

            public Custemer Get(int id){
                return customerRepository.Retrieve(id);
            }
           
    }
}