using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
namespace Aula008.data
{
 
    public class DataSet
    {
        
        public static List<Address> Addresses { get; set; }
        public static List<Custemer> Customers { get; set; } 
    
        public static List<Order_Item> order_Items { get; set; } 
        public static List<Order> orders { get; set ;}           
         public static List<Product> products{ get; set; } 
       
    }
    
}
    
