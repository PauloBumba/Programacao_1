using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Models
{
    public class Product
    {
        public string? ProductName {get;set;}
        public string? Description{get;set;}
        public string? current_price {get;set;}
         public bool  Validade (){
            return true;
        }
        public Product  Retrieve (){
            return new Product();
        }
        public void Save (Product product){
            
        }

 
    }
}