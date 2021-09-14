using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace OPAnalyzer1
{
    class StackoverflowProcessor
    {
        public static async Task<StackoverflowTopModel> LoadStackoverflowData(HttpClient  APIClient)
        {
            using (HttpResponseMessage response = await APIClient.GetAsync("faq?site=stackoverflow"))
            {
                if (response.IsSuccessStatusCode)
                {
                    StackoverflowTopModel dataModel = await response.Content.ReadAsAsync<StackoverflowTopModel>();
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
