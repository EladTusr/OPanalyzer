using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;


namespace OPAnalyzer1
{
    public class GITProcessor
    {
        public static async Task<GITTopModel>  LoadGitData(HttpClient APIClient)
        {
            using (HttpResponseMessage response = await APIClient.GetAsync("highcharts/commits"))
            {
                if (response.IsSuccessStatusCode)
                {
                    GITTopModel dataModel = await response.Content.ReadAsAsync<GITTopModel>();
                    return dataModel;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
