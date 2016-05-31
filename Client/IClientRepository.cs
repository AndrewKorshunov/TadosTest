using System;
using System.Collections.Generic;
using ClientsLibrary;

namespace ClientApp
{
    interface IClientRepository : IEnumerable<ClientEntity>
    {
        event Action RepositoryChanged;

        ClientEntity this[int index] { get; }

        void ForceUpdate();
        void ReplaceAt(int id, ClientEntity client);
        void Add(ClientEntity client);
        void RemoveAt(int id);
    }
}
