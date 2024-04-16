using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Data;
using Aula008.Models;
namespace Aula008.Repository
{
    public class ConstumerRepository
    {
        public void Save(Custemer custemer)     
        {
            DataSet.custemers.Add(custemer);

        }
        public Custemer Retrieve(int id)
        {
            foreach(var c in DataSet.custemers)
            {
                if(c.CustemerId == id){
                    return c;
                }
            }
            return null;
        }
    }
}