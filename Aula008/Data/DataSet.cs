using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
using Aula008.Repository;

namespace Aula008.Data
{
    public  class DataSet
    {
       
            public static List<Address> addresses{ get; set; }
            public static List<Custemer> custemers{get; set; }
            public static List<Order_Item> order_Items{ get; set; }
            public static List<Order> orders{get; set; }

            public static List<Product> products{ get; set; }
    }
}