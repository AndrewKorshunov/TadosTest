using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClientsLibrary;

namespace Server
{
    class DbConnector : IDataProvider
    {
        private readonly string connectionString;

        public DbConnector(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int AddClient(ClientEntity client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertCommand = string.Format(
                    "Insert into Clients(Name,CreationDate,Payment) values ('{0}', '{1}', {2})",
                    client.Name,
                    client.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    client.Payment.ToString().Replace(',', '.')
                    );
                var sqlCommand = new SqlCommand(insertCommand, connection);
                var affectedRows = sqlCommand.ExecuteNonQuery();

                return affectedRows;
            }
        }

        public int EditClient(int updateId, ClientEntity client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateString = string.Format(
                    "Update Clients set Name = '{0}', CreationDate = '{1}', Payment = {2} where Id = {3}",
                    client.Name,
                    client.CreationDate.ToString(),
                    client.Payment.ToString().Replace(',', '.'),
                    updateId
                    );
                var sqlCommand = new SqlCommand(updateString, connection);
                var affectedRows = sqlCommand.ExecuteNonQuery();

                return affectedRows;
            }
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sqlCommand = new SqlCommand("Select * from Clients", connection);
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
        }

        public int RemoveClient(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuerry = "Delete from Clients where Id=" + id;
                var sqlCommand = new SqlCommand(deleteQuerry, connection);
                var affectedRows = sqlCommand.ExecuteNonQuery();

                return affectedRows;
            }
        }
    }
}
