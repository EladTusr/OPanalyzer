using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;


namespace OPAnalyzer1
{
    public static class Analyzer
    {
        public static List<string> analyze(string datasourceName, List<string> outputlist, HttpClient APIclient)
        {
            Console.WriteLine(ApiParametersChooser.baseAdressChooser(datasourceName) +" here " + ApiParametersChooser.getAsyndData(datasourceName));
            APIclient.BaseAddress = ApiParametersChooser.baseAdressChooser(datasourceName);
            using (HttpResponseMessage response = APIclient.GetAsync(ApiParametersChooser.getAsyndData(datasourceName)).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    outputlist = MatchingInfoGetter.fetchRightData(datasourceName, outputlist, APIclient);
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    return outputlist;
                }
                return outputlist;
            }
          
        }
    }
}
