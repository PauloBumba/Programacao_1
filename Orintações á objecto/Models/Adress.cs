using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orintações_á_objecto.Models
{
    public class Adress
    {
        public int AdressId {get;set;}
        public string? Street{get;set;}
        public string? Distring {get;set;}
        public string? City {get;set;}
        public string? ZipCode {get;set;}
        public string? Country {get;set;}
        public int Number {get;set;}
        public string? FederalState{get;set;}
        public AddressType AdressType {get;set;}
       public enum AddressType
       {
            Comercial,
            residential
       }

    }
}