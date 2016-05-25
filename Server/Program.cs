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
            string connectionString = @"Data Source=(LocalDB)\v11.0;
                                        AttachDbFilename=C:\Users\Andrew\Desktop\SChool_mag\_AfterParty\TadosTest\Server\DB\ClientsDB.mdf;
                                        Integrated Security=True";
            var dataProvider = new DbConnector(connectionString);

            new Server(dataProvider).Start();
            Console.ReadKey();
        }
    }
}
