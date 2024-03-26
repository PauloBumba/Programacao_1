using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Elementos_do_Poo.Models
{
    public class Clinica
    {
        public int id { get; set;}
        public string? Nome { get; set;}

        public List<Atendimento> atendimentos {get;set;}

        public static int InstanceCount{get;set;}
        public int ObjectCount {get;set;}

    }
}