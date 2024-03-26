using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elementos_do_Poo.Models
{
    public class Aninal
    {
        public int? id {get;set;}
        public string? Raca {get;set;}
        public DateTime Data_Nascimento{get;set;}
        public string? Nome {get;set;}
        public string? NomeTutor{get;set;}
        public string?  FoneTutor{get;set;}

        
        public decimal peso {get;set;}
        public  decimal Altura {get;set;}


        public bool Validade(){

            var Isvalid=true;

            if (string.IsNullOrWhiteSpace(Nome))
                Isvalid=false;
                
            if (string.IsNullOrWhiteSpace(NomeTutor))
                Isvalid=false;
                
            return Isvalid;
        }

    }
}