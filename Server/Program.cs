using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using ClientsLibrary;

namespace Server
{
    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(ClientService));

            // Show exceptions to client
            //var d = host.Description.Behaviors.Find<ServiceDebugBehavior>();
            //d.IncludeExceptionDetailInFaults = true;
            host.Open();

            Console.ReadKey();
            host.Close();
        }
    }
}
