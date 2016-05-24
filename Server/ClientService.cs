using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using ClientsLibrary;
using System.Collections.Generic;

namespace Server
{    
    public class ClientService : IClientService
    {
        public IEnumerable<ClientEntity> GetAllClients()
        {
            return new[] { new ClientEntity() {
                Id = 666, 
                Name = "TestCode", 
                CreationDate = DateTime.Now, 
                Payment = 666 }};
        }

        public bool AddClient(ClientEntity client)
        {
            return true;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            if (updateId == 0) return true;
            return false;
        }

        public bool RemoveClient(int removeId)
        {
            if (removeId == 0) return true;
            return false;
        }
    }
}
