using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.data;
using Aula008.Models;
namespace Aula008.Repository
{
    public class CustomerRepository
    {
         
                       
        public void Save(Custemer customer)
        {
            DataSet.Customers.Add(customer);
        }

        public Custemer Retrieve(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustemerId == id )                
                    return c;                
            }

            return null;
        }
    }
    
}