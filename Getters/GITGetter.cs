using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace OPAnalyzer1
{
    public static class GITGetter 
    {

        public static async void gatherInfo(List<string> outputlist, HttpClient APIClient)
        {
            var dataModel =await GITProcessor.LoadGitData(APIClient);
            List<GITDataModel> mylist = dataModel.array;
            foreach (GITDataModel task in mylist)
            {
                outputlist.Add(task.array.commit.committer.message);
            }
        }
        public static List<string> getInfo (List<string> outputlist, HttpClient APIClient)
        {
            gatherInfo(outputlist, APIClient);
            return outputlist;
            
        }
    }
} 
