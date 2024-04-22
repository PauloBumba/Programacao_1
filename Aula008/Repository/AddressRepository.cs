using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula008.Models;
using Aula008.data;
namespace Aula008.Repository
{
    public class AddressRepository
    {
         public void Save(Address address )
        {
            DataSet.Addresses.Add(address);
        }

        public Address Retrieve(int id)
        {            
            foreach(var c in DataSet.Addresses)
            {
                if( c.Id_Address == id )                
                    return c;                
            }

            return null;
        }
    }
}