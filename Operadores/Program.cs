using System;
using System.Reflection.Metadata;

class Program {
    static void Main(){
        // OPERADORES 
        int a=3;
        int b=a++; // ++ é um incremento
        // neste caso ++ vai soamr a +1 
        // entretanto o acumulo ai ocrrer depois atrinuição 
        WriteLine($" a é {a} , b é  {b}");


        int c=3;
        int d=++c;
        WriteLine($"C é {c} e d é{d}");

<<<<<<< Updated upstream
        // NESTE CASO O ++ ESTA DO LADO ESUQERDO RDE C 
=======
<<<<<<< HEAD
        // NESTE CASO O ++ ESTA DO LADO ESQuERDO RDE C 
=======
        // NESTE CASO O ++ ESTA DO LADO ESUQERDO RDE C 
>>>>>>> main
>>>>>>> Stashed changes
        //O cUMULO OCORRERÁ ANTES DA ATRIBUIÇÃO

    //cOMBINANDO OPERADORES DE ATRIBUIÇÃO

    int p=6;
    p+=3; // Equivalente a p=p+3
    p-=3; // Equivalente a p=p-3
    p*=3; // Equivalente a p=p*3
    p/=3; // equivalnete a p =p /3


    //Operandores logicos 

    bool b_A =true;
    bool b_B=false;

    WriteLine($"And   || b_A  | b_B ");


    WriteLine($" b_A {b_A & b_A, -5} | {b_A  & b_B , -5}");
    
    WriteLine($"  {b_B & b_B, -5} | {b_A  & b_B , -5}");
    
    -WriteLine();

    WriteLine($"Or  || b_A  | b_B ");
    WriteLine($"  {b_A | b_A, -5} | {b_A |b_B , -5}");
    
    WriteLine($"  {b_B | b_B, -5} | {b_A  | b_B , -5}");
    
    WriteLine();

    WriteLine($" Xor || b_A  | b_B ");
    WriteLine($"  {b_A ^ b_A, -5} | {b_A ^ b_B , -5}");
    
    WriteLine($"  {b_B ^  b_B, -5} | {b_A  ^  b_B , -5}");
    

} }


