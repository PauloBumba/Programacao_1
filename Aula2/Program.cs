
using System ;
class Program 
{
//  Substituido Conteúdo 

static void Main(){
    //  Substituido Conteúdo 
    string NomeCompleto="Paulo Mario Valente Bumba";
    NomeCompleto= NomeCompleto.Replace("Valente", "Dalua");
    Console.WriteLine(NomeCompleto);
    //Comparação de string

    bool isNomeQual=(NomeCompleto=="Paulo Mario Valente Bumba");

    bool isNomeQual2=string.Equals(NomeCompleto,"Paulo Mario Valente Bumba") ;
    Console.WriteLine($"Primeiro resultado  {isNomeQual} ");
    Console.WriteLine($"Segundo  resultado  {isNomeQual2} ");

/*
sbyte :Armazena valores entre -128 a 127 
Short : Armazena valores entre 32,768 -32,767
Int  :valores entre -2,147,483 e 2,147,483
Int long : Amrazena valores entre  -9,223,372,036,854,775,808 e  9,223,372,036,854,775,808  

 */

 float myFloat=10f;
 double myDouble =5d;
 decimal MyDecimal=7m;
 int MyInterger=0;

}
}
