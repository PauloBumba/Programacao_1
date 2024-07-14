using System;
using MySql.Data.MySqlClient;
using Mysql_MVC_C_.Models;
using Mysql_MVC_C_.Data;

namespace Mysql_MVC_C_.Repository
{
    public class Repositorys
    {
        private Dataset dataset;

        public Repositorys()
        {
            dataset = new Dataset();
        }

        public void CreateCustomer(Customer customer)
        {
            string query = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";

            using (var connection = dataset.Connection)
            {
                try
                {
                    dataset.OpenConnection();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", customer.Name);
                        cmd.Parameters.AddWithValue("@Email", customer.Email);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Cliente adicionado com sucesso.");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao adicionar cliente: {ex.Message}");
                }
                finally
                {
                    dataset.CloseConnection();
                }
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT Name, Email FROM Customers";

            using (var connection = dataset.Connection)
            {
                try
                {
                    dataset.OpenConnection();

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Customer customer = new Customer
                                {
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString()
                                };
                                customers.Add(customer);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Erro ao obter clientes: {ex.Message}");
                }
                finally
                {
                    dataset.CloseConnection();
                }
            }

            return customers;
        }
    }
}
