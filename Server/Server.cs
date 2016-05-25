using ClientsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server: IDisposable
    {
        private readonly ServiceHost host;
        private readonly IDataProvider dataProvider;

        public Server(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
            host = new ServiceHost(typeof(ClientService));
        }

        public bool AddClient(ClientEntity client)
        {
            int affectedRows = dataProvider.AddClient(client);
            if (affectedRows == 1) return true;
            else return false;
        }

        public bool EditClient(int updateId, ClientEntity client)
        {
            // Should affect only 1 client
            int affectedRows = dataProvider.EditClient(updateId, client);
            if (affectedRows == 1) return true;
            else return false;
        }

        public IEnumerable<ClientEntity> GetAllClients()
        {
            return dataProvider.GetAllClients();
        }

        public bool RemoveClient(int removeId)
        {
            // Should affect only 1 client
            int affectedRows = dataProvider.RemoveClient(removeId);
            if (affectedRows == 1) return true;
            else return false;
        }

        public void Start() 
        {
            host.Open();
        }

        public void Dispose()
        {
            host.Close();
        }
    }
}
