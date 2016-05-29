using ClientsLibrary;
using System;
using System.Collections.Generic;

namespace ClientApp
{
    class ClientRepository : IDisposable, ClientApp.IClientRepository
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

        /* Клиента можно сделать так чтобы добавить в репозиторий
        public class UserNPC:INotifyPropertyChanged
        {
            private string name;
            public string Name { 
                get { return name; } 
                set { name = value; onPropertyChanged(this, "Name"); } 
            }
            public int grade;
            public int Grade { 
                get { return grade; } 
                set { grade = value; onPropertyChanged(this, "Grade"); } 
            }
        
            // Declare the PropertyChanged event
            public event PropertyChangedEventHandler PropertyChanged;
        
            // OnPropertyChanged will raise the PropertyChanged event passing the
            // source property that is being updated.
            private void onPropertyChanged(object sender, string propertyName)
            {
                if (this.PropertyChanged != null)
                {
                    PropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
                }
            }
         }
         */

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

        public ClientEntity this[int index]
        {
            get { return clients[index]; }
            //set { clients[index] = value; }
        }

        public bool AddClient(ClientEntity client)
        {
            var result = clientProxy.AddClient(client);

            clients.Add(client);
            InvokeEvent(ListChanged);

            return result;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            int realId = clients[updateId].Id;
            var callResult = clientProxy.EditClient(realId, client);
            clients[updateId] = client;

            InvokeEvent(ListChanged);
            return callResult;
        }

        public IReadOnlyCollection<ClientEntity> AllClients()
        {
            return clients as IReadOnlyCollection<ClientEntity>;
        }

        public IReadOnlyCollection<ClientEntity> GetAllClients()
        {
            var callResult = clientProxy.GetAllClients();
            clients = new List<ClientEntity>(callResult);

            return clients as IReadOnlyCollection<ClientEntity>;
        }

        public bool RemoveClient(int idInRepository)
        {
            int realId = clients[idInRepository].Id;
            var callResult = clientProxy.RemoveClient(realId);
            clients.RemoveAt(idInRepository);
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
