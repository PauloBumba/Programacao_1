using System;
using Mysql_MVC_C_.Data;

class Program
{
    static void Main(string[] args)
    {
        // Cria uma instância da classe Dataset
        var dataset = new Dataset();

        // Chama o método OpenConnection para abrir a conexão com o banco de dados
        dataset.OpenConnection();
        dataset.CloseConnection();
    }
}
