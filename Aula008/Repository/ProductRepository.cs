using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Data;
using Aula008.Models;


namespace Aula008.Repository
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            DataSet.products.Add(product);
        }
         public Product Retrieve(int id)
        {
            foreach(var c in DataSet.products)
            {
                if(c.Id == id){
                    return c;
                }
            }
            return null;
        }
    }
}