using System;
using System.Data;


class Program {
    static void Main(){
            while (true){
            Console.WriteLine(" suas opções");
            Console.WriteLine("----------1 -Primeira Opção Cálculo Aritmetico-------------");
            Console.WriteLine("----------2 Segunda Opção Sair------------------------------");
            Console.Write("informe um numero da opções acima  : ");
            string leitura= Console.ReadLine();
            int.TryParse(leitura, out int opcao);
            if(opcao==1){
                Console.WriteLine("Calculo aritimetico");
                Console.WriteLine();
                Console.WriteLine("Informe um número ");
                string numero1= Console.ReadLine();
                int.TryParse(numero1 , out int n1);
                Console.WriteLine("Informe um número ");
                string numero2= Console.ReadLine();
                int.TryParse(numero2 , out int n2);
                
                var Soma =n1+n2;
                var Sub =n1-n2;
                var Mult =n1*n2;
                float div=n1/n2;
                var resto =n1%n2;
                var raiz =n1^n2;
               
                Console.WriteLine();
                Console.WriteLine($"A soma entre {n1} e {n2} é igual a {Soma}");
                Console.WriteLine();
                Console.WriteLine($"A subtração  entre {n1} e {n2} é igual a {Sub}");
                 Console.WriteLine();
                Console.WriteLine($"A Multiplicação entre {n1} e {n2} é igual a {Mult}");
                 Console.WriteLine();
                Console.WriteLine($"A Divisão  entre {n1} e {n2} é igual a {div}");
                 Console.WriteLine();
                Console.WriteLine($"O resto da divião  entre {n1} e {n2} é igual a {resto}");
                 Console.WriteLine();
                Console.WriteLine($"A potencia entre {n1} e {n2} é igual a {raiz}");
                
               
                 Console.WriteLine();
                 Console.WriteLine("Programa terminadoo");
                 break;
                }
               
            
            else if(opcao==2){
                break;
            }
            else{
                Console.WriteLine();
                Console.WriteLine("Opcção errada");

                continue;
            }

                
            
    }
}
}