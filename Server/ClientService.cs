using System;
using System.Collections.Generic;
using System.Configuration;
using ClientsLibrary;

namespace Server
{
    public class ClientService : IClientService
    {
        private readonly DbConnector dataProvider;

        public ClientService()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ClientsDB"].ConnectionString;
            dataProvider = new DbConnector(connectionString);
        }

        public bool AddClient(ClientEntity client)
        {
            return dataProvider.AddClient(client);
        }

        public bool EditClient(ClientEntity client)
        {
            return dataProvider.EditClient(client);
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return dataProvider.GetAllClients();
        }

        public bool RemoveClient(int removeId)
        {
            return dataProvider.RemoveClient(removeId);
        }
    }
}
