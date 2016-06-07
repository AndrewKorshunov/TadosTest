using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ClientsLibrary
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        bool AddClient(ClientEntity client);

        [OperationContract]
        bool EditClient(ClientEntity client);

        [OperationContract]
        IEnumerable<ClientEntity> GetAllClients();

        [OperationContract]
        bool RemoveClient(int id);
    }
}
