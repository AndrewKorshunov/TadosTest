using ClientsLibrary;
using System;
using System.Collections.Generic;

namespace ClientApp
{
    class ClientRepository : IDisposable
    {
        // Add some error handling by
        // catch(FaultException) Abort();
        /* 
         try
        {       
            client.Close();
        }
        catch(FaultException)
        catch (CommunicationException e)
        catch (TimeoutException e)
        {
            client.Abort();
        }
        catch (Exception e)
        {
            client.Abort();
            throw;
        }        
         */

        // Только репозиторий знает реальный ИД, все остальные знают
        // только ИД в списке репозитория.

        private void TEST()
        {
            var t = new System.Collections.ObjectModel.ObservableCollection<ClientEntity>();
            //System.Collections.Specialized.NotifyCollectionChangedAction
        }

        private readonly ClientProxy clientProxy;
        private List<ClientEntity> clients;

        public ClientRepository(ClientProxy clientProxy)
        {
            clients = new List<ClientEntity>();
            this.clientProxy = clientProxy;
            this.clientProxy.Open();
        }

        public event Action ListChanged;

        public bool AddClient(ClientEntity client)
        {
            var result = clientProxy.AddClient(client);

            clients.Add(client);
            InvokeEvent(ListChanged);

            return result;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            /*
            int id = clients[view.SelectedClientIndex].Id;
            var newClient = new ClientEntity();

            clientProxy.EditClient(id, newClient);
            */
            int realId = clients[updateId].Id;
            var callResult = clientProxy.EditClient(realId, client);
            clients[updateId] = client;

            InvokeEvent(ListChanged);
            return callResult;
        }

        public IReadOnlyCollection<ClientEntity> GetAllClients()
        {
            var clients = clientProxy.GetAllClients();
            clientProxy.GetAllClients();

            return clients as IReadOnlyCollection<ClientEntity>;
        }

        public bool RemoveClient(int id)
        {
            var callResult = clientProxy.RemoveClient(id);
            clients.RemoveAt(id);
            InvokeEvent(ListChanged);
            
            return callResult;
        }

        public void Dispose()
        {
            clientProxy.Close();
        }

        private void InvokeEvent(Action action)
        {
            if (action != null)
                action();
        }
    }
}
