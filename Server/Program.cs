using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientsLibrary;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main()
        {
            //var server = new ClientService();
            var host = new ServiceHost(typeof(ClientService));
            host.Open();

            var cl = new ClientEntity() { Name = "CodeTEst", CreationDate = DateTime.Now, Payment = 123 };
            //server.AddClient(cl);
            //var t = server.GetAllClients();
            //server.RemoveClient(222);
            //server.EditClient(222, cl);



            Console.ReadKey();
            host.Close();
        }
    }
}
