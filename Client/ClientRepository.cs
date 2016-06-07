using System;
using System.Collections;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    class ClientRepository : IClientRepository, IDisposable
    {
        private readonly ClientProxy clientProxy;
        private List<ClientEntity> clients;

        public ClientRepository(ClientProxy clientProxy)
        {   
            this.clientProxy = clientProxy;
            this.clientProxy.Open();

            this.ForceUpdate();
        }
        
        public event Action RepositoryChanged;

        public int Count
        {
            get { return clients.Count; }
        }        
        public ClientEntity this[int index]
        {
            // Return readonly/copy?
            get { return clients[index]; }
        }

        public void Add(ClientEntity client)
        {
            bool succesful = clientProxy.AddClient(client);
            if (succesful)
            {
                clients.Add(client);
                InvokeEvent(RepositoryChanged);
            }
        }

        public void Dispose()
        {
            clientProxy.Close();
        }

        public void ForceUpdate()
        {
            clients = new List<ClientEntity>(clientProxy.GetAllClients());
        }

        public IEnumerator<ClientEntity> GetEnumerator()
        {
            return clients.GetEnumerator();
        }

        public void RemoveAt(int id)
        {
            int realId = clients[id].Id;
            bool succesful = clientProxy.RemoveClient(realId);
            if (succesful)
            {
                clients.RemoveAt(id);
                InvokeEvent(RepositoryChanged);
            }
        }
                
        public void ReplaceAt(int idInRepo, ClientEntity client)
        {
            // Only repository should know real id of client in DB
            int realId = clients[idInRepo].Id;
            client.Id = realId;
            bool succesful = clientProxy.EditClient(client);
            if (succesful)
            {
                clients[idInRepo] = client;
                InvokeEvent(RepositoryChanged);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void InvokeEvent(Action action)
        {
            if (action != null)
                action();
        }
    }
}
