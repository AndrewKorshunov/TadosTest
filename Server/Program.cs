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
            // Set absolute path to DB
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Andrew\Desktop\SChool_mag\_AfterParty\TadosTest\Server\DB\");            

            var host = new ServiceHost(typeof(ClientService));
            host.Open();

            Console.ReadKey();
            host.Close();
        }
    }
}
