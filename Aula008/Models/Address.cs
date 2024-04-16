using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace Aula008.Models
{

    public enum AddressTipe{
        residential,
        Commertial,
        Other

    }
    public class Address
    {
        public int id {get;set;}
        public string Street {get;set;}
        public string City {get;set;}
        public int ZipCode {get;set;}
        public string city { get;set;}
        public string zipCode {get;set;}

        public string FederalSatte {get;set;}
        public string Country {get;set;}
        public AddressTipe Type{get;set;}    
        public bool Isdefault{get;set;}

        public Custemer custemer{get;set;}

    }
}