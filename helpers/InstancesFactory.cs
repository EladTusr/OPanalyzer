using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;


namespace OPAnalyzer1
{
    /*
    * Simple class which will create the new objcets which will be needed
     * exeptions are simple types like Random
    */
    public static class InstancesFactory
    {
        public static HttpClient CreateHttpClient()
        {
            HttpClient client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");
            return client;
        }
        public static System.Net.Http.Headers.MediaTypeWithQualityHeaderValue CreateMediaType()
        {
            return new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
        }
        public static List<string> CreateStringList()
        {
            return new List<string>();
        }
        public static Uri CreateUri(string baseAdress)
        {
            if (baseAdress == "")
            {
                throw new InvalidOperationException("Illeagal request");
            }
            return new Uri(baseAdress);
        }
        public static string[] CreateArr(int size)
        {
            return new string[size];
        }

    }
}
