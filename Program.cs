using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
    class Program
    {
        static void Main(string[] args)
        {
             HttpClient client = InstancesFactory.CreateHttpClient();
             //ClientHelper.InitializClient(client);
             List<string> output = InstancesFactory.CreateStringList();
             output = Analyzer.analyze("Stackoverflow", output, client);
             output.ForEach(Console.WriteLine);
             Console.WriteLine("here");
             Console.ReadLine();


            /*     client.BaseAddress = new Uri("https://api.github.com/repos/highcharts/");
                HttpResponseMessage response = client.GetAsync("highcharts/commits").Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Making API Call...");
                 using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
                 {
                     // https://api.stackexchange.com/2.2/tags/highcharts/faq?site=stackoverflow
                     client.BaseAddress = new Uri("https://api.stackexchange.com/2.2/tags/highcharts/");
                     HttpResponseMessage response = client.GetAsync("faq?site=stackoverflow").Result;
                     response.EnsureSuccessStatusCode();
                     string result = response.Content.ReadAsStringAsync().Result;
                     Console.WriteLine("Result: " + result);
                 }
                 Console.ReadLine();*/


        }
    }
 
}
