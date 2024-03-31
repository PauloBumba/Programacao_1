using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004.models
{
    public class Negocio
    {
        public int id {get;set;}
        public Tipo_negocio tipo_Negocio{get;set;}
        public enum Tipo_negocio {
            venda , 
            Locação
        }
    }
}