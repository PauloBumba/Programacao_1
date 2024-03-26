using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace Elementos_do_Poo.Models
{
    public class Atendimento
    {
        public int id {get ;set;}
        public DateTime DtAtendimento {get; set;}
        public Aninal aninal {set;get;}
        public Veterinario veterinario {get;set;}
        public string Observacao {get;set;}
    }
}