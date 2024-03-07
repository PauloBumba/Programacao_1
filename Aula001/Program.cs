using System;


// trabalhando com variaveis 

string message1="";

// // inicializar com string vazia

string message2= null;
// inicializar com string vazia

string message3= System.String.Empty;
// Declarar uma string com valor implicito 

var message4 = "uma mensagem aleatória ";

Console.WriteLine(message4);


// concatenado Strings 

string concat = (message1 ==null ? "" : message1) + " "+ message2 + " " + message3 + " " + message4;

Console.WriteLine("\n" + concat);