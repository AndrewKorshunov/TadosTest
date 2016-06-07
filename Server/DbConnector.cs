using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientsLibrary;
using System.Globalization;

namespace Server
{
    class DbConnector
    {
        private readonly string connectionString;

        public DbConnector(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddClient(ClientEntity client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertCommand = "Insert into Clients(Name,CreationDate,Payment) values (@name, @creationDate, @payment)";
                    var sqlCommand = new SqlCommand(insertCommand, connection);
                    sqlCommand.Parameters.AddRange(new[] {
                        new SqlParameter("name", client.Name),
                        new SqlParameter("creationDate", client.CreationDate.ToString("s")),
                        new SqlParameter("payment", client.Payment.ToString(CultureInfo.InvariantCulture))
                        });
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch  // There should be different exception handlers for SqlConnection.Open and SqlCommand execution
                {
                    return false;
                }
            }
        }

        public bool EditClient(ClientEntity client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateString = "Update Clients set Name = @name, CreationDate = @creationDate, Payment = @payment where Id = @id";
                    var sqlCommand = new SqlCommand(updateString, connection);
                    sqlCommand.Parameters.AddRange(new[] {
                        new SqlParameter("id", client.Id),
                        new SqlParameter("name", client.Name),
                        new SqlParameter("creationDate", client.CreationDate.ToString("s")),
                        new SqlParameter("payment", client.Payment.ToString(CultureInfo.InvariantCulture))
                        });
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch  // There should be different exception handlers for SqlConnection.Open and SqlCommand execution
                {
                    return false;
                }
            }
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuerry = "Select * from Clients";
                    var sqlCommand = new SqlCommand(selectQuerry, connection);
                    var dataReader = sqlCommand.ExecuteReader();
                    var clients = new List<ClientEntity>();
                    while (dataReader.Read())
                    {
                        clients.Add(new ClientEntity()
                        {
                            Id = dataReader.GetInt32(0),
                            Name = dataReader.GetString(1),
                            CreationDate = dataReader.GetDateTime(2),
                            Payment = dataReader.GetDecimal(3)
                        });
                    }
                    dataReader.Close();
                    return clients;
                }
                catch  // There should be different exception handlers for SqlConnection.Open and SqlCommand execution
                {
                    return new List<ClientEntity>();
                }
            }
        }

        public bool RemoveClient(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuerry = "Delete from Clients where Id=@id";
                    var sqlCommand = new SqlCommand(deleteQuerry, connection);
                    sqlCommand.Parameters.AddWithValue("id", id);
                    sqlCommand.ExecuteNonQuery();

                    return true;
                }
                catch  // There should be different exception handlers for SqlConnection.Open and SqlCommand execution
                {
                    return false;
                }
            }
        }
    }
}
