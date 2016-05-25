using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using ClientsLibrary;

namespace Server
{    
    public class ClientService : IClientService
    {
        public ClientService(IServerLogic logc)
        {
        }

        public bool AddClient(ClientEntity client)
        {
            return false;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            return false;
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return new[] { new ClientEntity() };
        }

        public bool RemoveClient(int removeId)
        {
            return false;
        }
    }
}
