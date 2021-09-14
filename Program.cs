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




        }
    }
 
}
