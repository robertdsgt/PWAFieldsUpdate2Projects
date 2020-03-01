using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
 

namespace PWAUpdates
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(getProjectName("Project Name"));

        }
    

     private static string getProjectName(string pwaColumnName)
    {
        string jsonFilePath = @"/Users/robert/Projects/PWAUpdates/PWAUpdates/ProjectMap.json";

        string json = File.ReadAllText(jsonFilePath);
        Dictionary<string, string> json_Dictionary = (new JavaScriptSerializer()).Deserialize<Dictionary<string, string>>(json);


        // Console.WriteLine(json_Dictionary["Project Name"].ToString());
        return json_Dictionary[pwaColumnName].ToString();

    }
}
}
