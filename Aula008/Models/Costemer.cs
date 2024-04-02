using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Aula008.Models
{
    public class Custemer
    {
        public int CustemerId {get;set;}
        public string? Name {set;get;}
        public string? Email_adress {set;get;}
        public string? HomeAdress {set;get;}
        public string? WorkAdress {set;get;}
        public Custemer(){
            
        }
        public Custemer (int id){
            CustemerId=id;

        }
        public bool  Validade (){
          var IsValid=true;
          if(string.IsNullOrEmpty(Name))
            IsValid=false;
          
          if(string.IsNullOrEmpty(Email_adress))
            IsValid=false;
          
          return IsValid;
        }
        public Custemer  Retrieve (int custemerId){
            return new Custemer();
        }
        public List<Custemer>  Retrieve (){
            return new List<Custemer>();
        }
        public void Save (Custemer custemer){

        }


    }
}