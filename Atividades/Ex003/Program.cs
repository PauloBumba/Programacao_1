using System;

class Program {
    static void Main(){
      while (true){
        Console.WriteLine("Informe um Operador que deseja fazer a tabuada         :");
        Console.WriteLine("--------------Soma(Digite sinal  de +) ----------------");
        Console.WriteLine("--------------Subs(Digite sinal  de *) ----------------");
        Console.WriteLine("--------------Mult(Digite sinal  de -) ----------------");
        Console.WriteLine("--------------Divi(Digite sinal  de +) ----------------");
        string Opcao=Console.ReadLine();
        Console.WriteLine();
        if (Opcao=="+"){
        Console.WriteLine("------------------Tabuada de 1----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{1} + {i} = {1+i}");

            } Console.WriteLine();
           
        Console.WriteLine("------------------Tabuada de 2----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{2} + {i} = {2+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 3----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{3} + {i} = {3+i}");

            } Console.WriteLine();
       
        Console.WriteLine("------------------Tabuada de 4----------------------------------");
             for(int i=0;i<=9;i++){
                Console.WriteLine($"{4} + {i} = {4+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 5----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{5} + {i} = {5+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 6----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{6} + {i} = {6+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 7----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{7} + {i} = {7+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 8----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{8} + {i} = {8+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 9----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{9} + {i} = {9+i}");

            } Console.WriteLine();
        break;
        }
        else if (Opcao=="*"){
      
        Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 1----------------------------------");
            for(int i=0;i<=9;i++){
                 Console.WriteLine($"{1} * {i} = {1*i}");

            }
            Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 2----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{2} * {i} = {2*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 3----------------------------------");
            for(int i=0;i<=9;i++){

                Console.WriteLine($"{3} * {i} = {3*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 4----------------------------------");
            for(int i=0;i<=9;i++){

                Console.WriteLine($"{4} * {i} = {4*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 5----------------------------------");
            for(int i=0;i<=9;i++){

                Console.WriteLine($"{5} * {i} = {5*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 6----------------------------------");
            for(int i=0;i<=9;i++){

                Console.WriteLine($"{6} * {i} = {6*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 7----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{7} * {i} = {7*i}");
            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 8----------------------------------");
               
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{8} * {i} = {8*i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 9----------------------------------");
                
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{9} * {i} = {9*i}");

            } Console.WriteLine();
               
        break;

        }
        else if (Opcao=="-"){
             Console.WriteLine();
             Console.WriteLine("------------------Tabuada de 1----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{1} - {i} = {1-i}");

            }
            Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 2----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{2} - {i} = {2-i}");

            }
             Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 3----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{3} - {i} = {3-i}");

            }
        Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 4----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{4} - {i} = {4-i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 5----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{5} - {i} = {5-i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 6----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{6} - {i} = {6-i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 7----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{7} - {i} = {7-i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 8----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{8} - {i} = {8-i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 9----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{9} - {i} = {9-i}");

            } Console.WriteLine();
        break;

        }
        else if (Opcao=="/"){
            Console.WriteLine();
             Console.WriteLine("------------------Tabuada de 1----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{1} / {i} = {1+i}");

            } Console.WriteLine();
            Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 2----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{2} / {i} = {2+i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 3----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{3} / {i} = {3+i}");

            } Console.WriteLine();
       
        Console.WriteLine("------------------Tabuada de 4----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{4} / {i} = {4/i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 5----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{5} / {i} = {5/i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 6----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{6} / {i} = {6/i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 7----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{7} / {i} = {7/i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 8----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{8} / {i} = {8/i}");

            } Console.WriteLine();
        Console.WriteLine("------------------Tabuada de 9----------------------------------");
            for(int i=0;i<=9;i++){
                Console.WriteLine($"{9} / {i} = {9/i}");

            } Console.WriteLine();
        break;

        }
        else{
            Console.WriteLine("Erro na sintaxe , certifica que foi digitado simbolo corretamente");
            Console.WriteLine();
        }
      }
    }
}