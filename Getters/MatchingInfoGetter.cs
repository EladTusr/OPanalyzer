using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace OPAnalyzer1
{
    public static class MatchingInfoGetter
    {
        public static List<string> fetchRightData(string requestParameters, List<string> outputlist, HttpClient APIClient)
        {
            switch (requestParameters)
            {
                case "Stackoverflow":;
                    StackoverflowGetter getter = InstancesFactory.CreateSGeter(outputlist, APIClient);
                    getter.getInfo();
                    break;

                case "Github":;
                    GITGetter.getInfo(outputlist, APIClient);
                    break;
            }

            return outputlist;
        }
    }
}
