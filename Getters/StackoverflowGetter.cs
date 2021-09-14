using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OPAnalyzer1
{
    public class StackoverflowGetter 
    {
        public  List<string> outputlist { get; set; }
        public HttpClient APIClient { get; set; }

        public StackoverflowGetter(List<string> list, HttpClient clinet)
        {
            outputlist = list;
            APIClient = clinet;
        }
        public async void gatherInfo()
        {

            var dataModel = await StackoverflowProcessor.LoadStackoverflowData(APIClient);
            StackoverflowData[] myArray = dataModel.Items;
            foreach (StackoverflowData task in myArray)
            {
                string theTitle = task.title;
                this.outputlist.Add(theTitle);
            }
        }
        public List<string> getInfo()
        {
            gatherInfo();
            return this.outputlist;
        }
    }
}
