using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Data;
using Aula008.Models;

namespace Aula008.Repository
{
    public class OrderI_itemRepository
    {
       public void Save(Order_Item orderI_Ite )
       {
            DataSet.order_Items.Add( orderI_Ite );
       }
        public Order_Item Retrieve(int id)
        {
            foreach(var c in DataSet.order_Items)
            {
                if(c.Id == id){
                    return c;
                }
            }
            return null;
        }
    }
}