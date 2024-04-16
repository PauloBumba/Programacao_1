using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
using  Aula008.Data;

namespace Aula008.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)     
        {
            DataSet.addresses.Add(address);

        }
         public Address Retrieve(int id)
        {
            foreach(var c in DataSet.addresses)
            {
                if(c.id == id){
                    return c;
                }
            }
            return null;
        }

    }
}