using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ClientsLibrary;

namespace Server
{    
    public class ClientService : IClientService
    {
        private readonly DbConnector dbConnector;

        public ClientService()
        {
            this.dbConnector = new DbConnector();
        }

        public bool AddClient(ClientEntity client)
        {
            int affectedRows = dbConnector.AddClient(client);
            if (affectedRows == 1) return true;
            else return false;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            // Should affect only 1 client
            int affectedRows = dbConnector.EditClient(updateId, client);
            if (affectedRows == 1) return true;
            else return false;
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return dbConnector.GetAllClients();
        }

        public bool RemoveClient(int removeId)
        {
            // Should affect only 1 client
            int affectedRows = dbConnector.RemoveClient(removeId);
            if (affectedRows == 1) return true;
            else return false;
        }
    }
}
