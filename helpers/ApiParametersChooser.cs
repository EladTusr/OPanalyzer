using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;

namespace OPAnalyzer1
{
    /*
     * This class will define the base url and flages for the HttpClient based on the parameters 
     */
    public static class ApiParametersChooser
    {
        public static string async_data = "";
        public static Uri baseAdressChooser(string requestParameters)
        {
            if (requestParameters == "Stackoverflow")
            {
                Uri StackoveflowBaseAdress = InstancesFactory.CreateUri("https://api.stackexchange.com/2.2/tags/highcharts/");
                return StackoveflowBaseAdress;
            }                   
            else if(requestParameters == "Github")
            {
               Uri GITBaseAdress = InstancesFactory.CreateUri("https://api.github.com/repos/highcharts/highcharts/commits");
                return GITBaseAdress;
            }
            return InstancesFactory.CreateUri("");
        }
        public static string getAsyndData (string requestParameters)
        {
            
            switch (requestParameters)
             {
                case "Stackoverflow":
                    async_data = "faq?site=stackoverflow";
                    break;

                case "Github":
                    async_data = "";
                    break;
             }

            return async_data;
            
        }
    }


}
