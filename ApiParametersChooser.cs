using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
    public static class ApiParametersChooser
    {
        public static string asyncData = "";
        public static Uri baseAdressChooser(string requestParameters)
        {
            if (requestParameters == "Stackoverflow")
            {
                Uri StackoveflowBaseAdress = InstancesFactory.CreateUri("https://api.stackexchange.com/2.2/tags/highcharts/");
                return StackoveflowBaseAdress;
            }                   
            else if(requestParameters == "Github")
            {
               Uri GITBaseAdress = InstancesFactory.CreateUri("https://api.github.com/repos/highcharts/");
                return GITBaseAdress;
            }
            return InstancesFactory.CreateUri("");
        }
        public static string getAsyndData (string requestParameters)
        {
            
            switch (requestParameters)
             {
                case "Stackoverflow":
                    asyncData = "faq?site=stackoverflow";
                    break;

                case "Github":
                    asyncData = "highcharts/commits";
                    break;
             }

            return asyncData;
            
        }
    }


}
