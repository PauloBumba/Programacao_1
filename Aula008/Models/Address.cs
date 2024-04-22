using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula008.Models
{
  

        public enum AddressType
        {
            Residential,
            Commercial,
            Other
        }

        public class Address
        {
            public int Id_Address { get; set; }       
            public AddressType Type { get; set; } 
            public string Street { get; set; }
            public string District { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string FederalState { get; set; }
            public string Country { get; set; }
            public bool IsDefault { get; set; }

            public Custemer Customer {get; set;}
        }
    }
