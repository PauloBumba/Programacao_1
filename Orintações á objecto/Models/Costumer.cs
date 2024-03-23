using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orintações_á_objecto.Models
{
    public class Costumer
    {
        public int CostumerId{get;set;}
        public string? EmailAdress{get;set;}
        public string? FirstName{get;set;}
        public string? LastName{get;set;}

        public DateTime BirthDate{get;set;}

        //public Adress Adress1{get;set;}
        //public Adress Adress2{get;set;}

        public List<Adress> Adresses=new List<Adress>();

        public bool Validade(){
            return true;
        }
       
    }
}