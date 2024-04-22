using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
using Aula008.Models;
using Aula008.data;
namespace Aula008.Repository
{
    public class OrderItemRepository
    {
         public void Save(Order_Item order_Item)
        {
            DataSet.order_Items.Add(order_Item);
        }

        public Order_Item Retrieve(int id)
        {            
            foreach(var c in DataSet.order_Items)
            {
                if( c.Id_order_item == id )                
                    return c;                
            }

            return null;
        }
    }
}