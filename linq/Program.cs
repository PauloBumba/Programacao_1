List<string> lista = new List<string> { "maçã", "banana", "cereja", "damasco" };
int indice = lista.FindIndex(x => x == "cereja");
Console.WriteLine(indice); // Saída: 2
