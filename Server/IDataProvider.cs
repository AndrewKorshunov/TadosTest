using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientsLibrary;

namespace Server
{
    interface IDataProvider
    {
        int AddClient(ClientEntity client);
        int EditClient(int updateId, ClientEntity client);
        IEnumerable<ClientEntity> GetAllClients();
        int RemoveClient(int id);
    }
}
