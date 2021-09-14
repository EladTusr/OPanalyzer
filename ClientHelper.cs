using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
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
