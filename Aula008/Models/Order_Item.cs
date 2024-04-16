using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Models
{
    public class Order_Item
    {

        public int Id { get; set;}
        public Product? product {get;set;}
        public string? Quantity {get;set;}
        public double? Purchase_price {get;set;}
        public bool  Validade (){
            return true;
        }
        public Order_Item  Retrieve (){
            return new Order_Item();
        }
        public void Save (Order_Item order_Item){
            
        }



    }
}