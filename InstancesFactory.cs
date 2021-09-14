using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;


namespace OPAnalyzer1
{
    public static class InstancesFactory
    {
        public static HttpClient CreateHttpClient()
        {
            return new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
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
            return new Uri(baseAdress);
        }
        public static StackoverflowGetter CreateSGeter (List<string> list, HttpClient client)
        {
            return new StackoverflowGetter(list, client);
        }


    }
}
