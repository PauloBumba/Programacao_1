using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004.models
{
    public class Itens
    {
        public int Id {set;get;}
        public string Nome {get;set;}
        public string  Descrição{get; set;}
        public int Valor {get;set;}
        public int  Nrode_Comodos {get;set;}

        public categoria Id_categoria {get;set;}
        public Localizacao id_localizacao {set;get;}
        public Negocio id_negocio {set;get;}

        
        
    }
}