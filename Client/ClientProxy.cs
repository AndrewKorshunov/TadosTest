using System;
using System.ServiceModel;
using System.Collections.Generic;
using ClientsLibrary;


namespace ClientApp
{
    public class ClientProxy: ClientBase<IClientService>, IClientService
    {
        public bool AddClient(ClientEntity client)
        {
            return Channel.AddClient(client);
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            return Channel.EditClient(updateId, client);
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return Channel.GetAllClients();
        }

        public bool RemoveClient(int id)
        {
            return Channel.RemoveClient(id);
        }
    }
}