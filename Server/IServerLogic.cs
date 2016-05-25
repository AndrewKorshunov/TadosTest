using ClientsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    public interface IServerLogic
    {
        bool AddClient(ClientEntity client);
        bool EditClient(int updateId, ClientEntity client);
        IEnumerable<ClientEntity> GetAllClients();
        bool RemoveClient(int removeId);
    }
}
