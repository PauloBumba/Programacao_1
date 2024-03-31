using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Ex004.models
{
    public class Localizacao
    {
       public  int  Id  {set;get;}
       public Tipo_localizacao tipoLocalizacao {get;set;}

       public enum Tipo_localizacao{
        Rural,
        Urbano
       }
    }
}