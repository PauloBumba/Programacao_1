using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.data;
using Aula008.Models;
namespace Aula008.Repository
{
    public class OrderRepository
    {
         public void Save(Order orders)
        {
            DataSet.orders.Add(orders);
        }

        public Order Retrieve(int id)
        {            
            foreach(var c in DataSet.orders)
            {
                if( c.Id_order == id )                
                    return c;                
            }

            return null;
        }
    }
}