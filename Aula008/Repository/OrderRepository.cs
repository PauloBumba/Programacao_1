using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Data;
using Aula008.Models;


namespace Aula008.Repository
{
    public class OrderRepository
    {
        public void Save (Order order)
        {
            DataSet.orders.Add(order);

        }
         public Order Retrieve(int id)
        {
            foreach(var c in DataSet.orders)
            {
                if(c.Id == id){
                    return c;
                }
            }
            return null;
        }
    }
}