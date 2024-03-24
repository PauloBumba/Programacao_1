using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Ex004.Dados
{
    public class Categoria:Imoveis
    {
        //classificando-os por categoria (Apartamentos, Casas, Sítios) 
    
        public bool Apartamentos{get;set;}
        public bool Casas{get;set;}
        public bool Sitios{get;set;}
    }
}