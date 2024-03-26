using System;
namespace Elementos_do_Poo.Models {
    class Program {
        static void Main(){

            //Primeira Clinica 
            Clinica c1 =new Clinica();
            c1.ObjectCount=1;
            Clinica.InstanceCount=1;

            // Segunda clinica 

            Clinica c2 =new Clinica();
            Clinica.InstanceCount++;
            c2.ObjectCount=10;
            Console.WriteLine($"Valor C1 : {c1.ObjectCount}");
            Console.WriteLine($"IstanceCount  :  {Clinica.InstanceCount}");
            Console.WriteLine($"Valor C2 :  {c2.ObjectCount}");



            
            

        }
    }
}