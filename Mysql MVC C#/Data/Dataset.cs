using System;
using MySql.Data.MySqlClient;

namespace Mysql_MVC_C_.Data
{
    public class Dataset
    {
        private MySqlConnection connection;
        private static readonly string ConnectionString = "server=localhost; " +
                                                           "uid=root; " +
                                                           "database=CustomerDB; " +
                                                           "password=root;";

        // Construtor da classe Dataset
        public Dataset()
        {
            connection = new MySqlConnection(ConnectionString);
        }

        // Método para abrir a conexão
        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
            }
        }

        // Método para fechar a conexão
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexão fechada com sucesso.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
            }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               

        // Propriedade para acessar a conexão
        public MySqlConnection Connection => connection;
    }
}
