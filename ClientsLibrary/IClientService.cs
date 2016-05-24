using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ClientsLibrary
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        IEnumerable<ClientEntity> GetAllClients();

        [OperationContract]
        bool AddClient(ClientEntity client);

        [OperationContract]
        bool EditClient(int updateId, ClientEntity client);

        [OperationContract]
        bool RemoveClient(int id);
    }
}
