using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004.Dados
{
    public class Imoveis
    {
         //Nome, Descrição, Valor, Nro de Comodos e também uma listagem de Imagens.
        public string? Name {get;set;}
        public string? Describe{get;set;}
        public int Number_of {get;set;}
        public Tipo_de_localidade  Localidade {get;set;}

        public List<Categoria> categorias= new List<Categoria>();
        public enum Tipo_de_localidade{
            Rural,
            Urbano 
        }
        public Tipo_de_negocio Negocio {get;set;}
        public enum Tipo_de_negocio{
            Locação ,
             Venda
        }


    }
}