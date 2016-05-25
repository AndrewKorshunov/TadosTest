using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Configuration;
using ClientsLibrary;

namespace Server
{
    public class ClientService : IClientService
    {
        IDataProvider dataProvider;

        public ClientService()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ClientsDB"].ConnectionString;
            dataProvider = new DbConnector(connectionString);
        }
        
        public bool AddClient(ClientEntity client)
        {
            int affectedRows = dataProvider.AddClient(client);
            if (affectedRows == 1) return true;
            else return false;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {                
            int affectedRows = dataProvider.EditClient(updateId, client);
            // Should affect only 1 client    
            if (affectedRows == 1) return true;
            else return false;
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return dataProvider.GetAllClients();
        }

        public bool RemoveClient(int removeId)
        {
            int affectedRows = dataProvider.RemoveClient(removeId);
            // Should affect only 1 client    
            if (affectedRows == 1) return true;
            else return false;
        }
    }
}
