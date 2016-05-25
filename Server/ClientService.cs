using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ClientsLibrary;

namespace Server
{    
    public class ClientService : IClientService
    {
        public bool AddClient(ClientEntity client)
        {
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
        }

        public bool RemoveClient(int removeId)
        {
        }
    }
}
