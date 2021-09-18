using System;
using System.Collections.Generic;
using System.Text;

namespace OPAnalyzer1
{
    /*
     * This class contains some usfull methoed for manipulating data in an array
     * this methodes will be used to move the data from an array to a list eventually.
     */
    public static class MyArrayHelper
    {
        public static string[] removeTheRest(string str, string[]arr)
        {
            for (int i=0; i<arr.Length; i++ )
            {
                string orig_string = arr[i];
                int location = orig_string.IndexOf(str);
                arr[i] = orig_string.Substring(0, location);
            }
            return arr;
        }

        public static string[] removeFirstCell(string[] arr)
        {
            string[] output_arr = InstancesFactory.CreateArr(arr.Length-1);
            for (int i =1; i<arr.Length; i++)
            {
                output_arr[i-1] = arr[i];
            }
            return output_arr;
        }
        public static string[] removeApostrophes(string[] arr)
        {
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = arr[i].Replace("\"", "");
            }
            return arr;
        }
        public static List<string> moveToList(string[] arr)
        {
            List<string> my_list = InstancesFactory.CreateStringList();
            foreach (string str in arr)
            {
                my_list.Add(str);
            }
            return my_list;
        }
    }
}
