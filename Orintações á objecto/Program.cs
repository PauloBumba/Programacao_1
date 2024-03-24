using System.Data;
using Orintações_á_objecto.Models;

Costumer c1 =new Costumer();

c1.CostumerId=1;
c1.FirstName="Paulo";
c1.LastName="Bumba";
c1.BirthDate =new DateTime();
c1.EmailAdress="paulomvbumba@gmal.com";



Console.WriteLine($"Meu nome {c1.FirstName} {c1.LastName}  ");
Console.WriteLine($"Meu email  {c1.EmailAdress}  ");


Adress adress1=new Adress();
adress1.Street="Capalanca";
adress1.Distring="Viana";
adress1.FederalState="Lda";
adress1.AdressId=1;
adress1.Number=68;
adress1.City="Luanda";
adress1.Country="Angola";
adress1.AdressType=Adress.AddressType.Comercial;
c1.Adresses.Add(adress1);

Console.WriteLine("Endereços :");
foreach(var Print in c1.Adresses){

    Console.Write("--------Rua----------");
    Console.WriteLine($"{Print.Street}");
    Console.WriteLine(Print.AdressType);
    Console.Write("--------Estado----------");
    Console.WriteLine($"{Print.FederalState}");
    Console.Write("--------Cidade----------");
    Console.WriteLine($"{Print.City}");
    Console.Write("--------Numero----------");
    Console.WriteLine($"{Print.Number}");
    Console.Write("--------Pais----------");
    Console.WriteLine($"{Print.Country}");
   
}