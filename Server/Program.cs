using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientsLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

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
