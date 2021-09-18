using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
    /*
     * This class will be used to control the client.
     * from this class the initialization and the disposiol of the clint will take place.
     */
    public static class ClientHelper
    {
        public static void InitializClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(InstancesFactory.CreateMediaType());
        }
        public static void DeleteClient(HttpClient client)
        {
            client.Dispose();
        }
    }
}
