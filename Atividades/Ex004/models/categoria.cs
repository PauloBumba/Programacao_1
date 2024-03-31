using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004.models
{
    public class categoria
    { 

        public int Id {get;set;} 
        public Tipocategooria tipocategooria {set;get;}
        public enum Tipocategooria{
            Apartamento, 
            Casa,
            Sitio
        }
    }
}