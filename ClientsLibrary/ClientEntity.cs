using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ClientsLibrary
{
    [DataContract]
    public class ClientEntity
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public decimal Payment { get; set; }
    }
}
