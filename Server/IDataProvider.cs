using System;
using System.Collections.Generic;
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
