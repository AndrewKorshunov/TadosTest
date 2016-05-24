using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClientsLibrary;

namespace Server
{
    class DbConnector : IDisposable, IClientService
    {
        private SqlConnection connection;

        public DbConnector()
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;
                                        AttachDbFilename=C:\Users\Andrew\Desktop\SChool_mag\_AfterParty\TadosTest\Server\DB\ClientsDB.mdf;
                                        Integrated Security=True";
            connection = new SqlConnection(connectionString);            
            connection.Open();
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
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
            return clients;
        }
        
        public bool AddClient(ClientEntity client)
        {
            string insertCommand = string.Format(
                "Insert into Clients(Name,CreationDate,Payment) values ('{0}', '{1}', {2})", 
                client.Name, 
                client.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"), 
                client.Payment 
                );
            var sqlCommand = new SqlCommand(insertCommand, connection);            
            var TTT = sqlCommand.ExecuteNonQuery();
            return true;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            string updateString = string.Format(
                "Update Clients set Name = '{1}', CreationDate = '{2}', Payment = {3} where Id = {4}",
                client.Id,
                client.Name,
                client.CreationDate.ToString(),
                client.Payment,
                updateId
                );
            var sqlCommand = new SqlCommand(updateString, connection);
            var TTT = sqlCommand.ExecuteNonQuery();
            return true;
        }

        public bool RemoveClient(int id)
        {
            string deleteQuerry = "Delete from Clients where Id=" + id;
            var sqlCommand = new SqlCommand(deleteQuerry, connection);
            var TTT = sqlCommand.ExecuteNonQuery();
            return true;
        }

        public void Dispose()
        {
            connection.Close();
        }

        /* 
        public DataSet SelectUserDetails()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegistrationTable", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
 
        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=registration;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable(UserName,Password,Country,Email) values(@UserName,@Password,@Country,@Email)", con);
            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            cmd.Parameters.AddWithValue("@Password", userInfo.Password);
            cmd.Parameters.AddWithValue("@Country", userInfo.Country);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + " Details inserted successfully";
            }
            else
            {
                Message = userInfo.UserName + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
         */
    }
}
