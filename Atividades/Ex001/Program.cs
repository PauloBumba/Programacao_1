using System;

class Program {
    static void Main(){
        Console.WriteLine("-------------------Seja benvindo ao nosso Programa ------------------------");
        Console.WriteLine("-------------------Digite os seus dados para Cadastro------------------------");


        Console.WriteLine("Informe o seu nome : ");
        string Nome =Console.ReadLine();
        Console.WriteLine("Informe o seu Email : ");
        string Email =Console.ReadLine();
        Console.WriteLine("Informe o seu Data de Nascimento : ");
        string Data_de_Nascimento =Console.ReadLine();
        Console.WriteLine("Informe o seu  Genero: ");
        string Genero =Console.ReadLine();
        Console.WriteLine("Informe o seu Endereço : ");
        string  Endereco=Console.ReadLine();
        Console.WriteLine("Informe o seu Cep : ");
        string  Cep=Console.ReadLine();
        Console.WriteLine("Informe o seu Rua: ");
        string Rua=Console.ReadLine();
        Console.WriteLine("Informe o seu  Bairro: ");
        string Bairro=Console.ReadLine();
        Console.WriteLine("Informe o seu Pais: ");
        string Pais=Console.ReadLine();
        Console.WriteLine("Informe o seu Cidade: ");
        string Cidade=Console.ReadLine();
        Console.WriteLine("Informe o seu Unidade_Ferativa: ");
        string Unidade_Ferativa=Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("-------Aguarde o resultado -----------");

         Console.WriteLine();


        Console.WriteLine($" {Nome} de email {Email} nascido aos {Data_de_Nascimento}  de genero {Genero}  residente no bairro {Bairro} na rua {Rua} com o cep {Cep} na unidade federativa {Unidade_Ferativa} no pais de {Pais}");

        Console.WriteLine("Resultado a Cima");
    }




}