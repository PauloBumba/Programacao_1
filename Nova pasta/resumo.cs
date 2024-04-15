using System;

// Classe base (pai)
class Veiculo
{
    public string Modelo { get; set; }
    public void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

// Classe derivada (filha)
class Carro : Veiculo
{
    public void LigarMotor()
    {
        Console.WriteLine("Motor ligado!");
    }
}

class Program
{
    static void Main()
    {
        // Criando um objeto do tipo Carro
        var meuCarro = new Carro();
        meuCarro.Modelo = "Sedan";

        // Acessando atributos e métodos
        Console.WriteLine($"Modelo do carro: {meuCarro.Modelo}");
        meuCarro.Mover(); // Herdado da classe Veiculo
        meuCarro.LigarMotor();

        // Exemplo de encapsulamento: os detalhes internos (como o funcionamento do motor) estão ocultos.
    }
}
