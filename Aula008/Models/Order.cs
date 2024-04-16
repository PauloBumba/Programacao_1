using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Models
{
    public class Order
    {

        public int Id { get; set;}
        public Custemer ?custemer {get;set;}
        public DateTime Orderdate {get;set;}
        public string ?shipping_adress {get;set;}
        public List<Order_Item>? order_Items {get;set;}
        public bool  Validade (){
            return true;
        }
        public Order  Retrieve (){
            return new Order();
        }
        public void Save (Order product){
            
        }





    }
}