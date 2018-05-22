using Pizzaria.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DAL
{
    public static class Database
    {
        private const string connectionString =
            "server=(local)\\SQLEXPRESS;database=Pizzaria;Integrated Security=SSPI";

        internal static List<Pizza> ObterListaDePizzas()
        {
            var pizzas = new List<Pizza>();

            using (var connection = new SqlConnection(connectionString))
            {
                const string query = "SELECT * FROM Pizza";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pizza = new Pizza();
                            pizza.Nome = reader.GetString(1);
                            pizza.Preco = reader.GetDecimal(2);
                            pizzas.Add(pizza);
                        }
                    }
                }
            }

            return pizzas;
        }

        internal static void SalvarCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = $@"INSERT INTO Cliente(Nome, Endereco, Telefone)
VALUES('{cliente.Nome}', '{cliente.Endereco}', '{cliente.Telefone}'); ";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
