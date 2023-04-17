using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DEMOQATests.JSONReader;

public static class JSONProvider
{
    public static string GetProperty(string propertyKey)
    {
        string json = ReadJSON();
        JObject data;
        
        try
        {
            data = JObject.Parse(json);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return data[propertyKey]!.Value<string>();;
    }

    public static List<string> GetProperties(string propertiesKey)
    {
        List<string> properties = new List<string>();
        String json = ReadJSON();
        JObject jo = JObject.Parse(json);
        JArray propertiesObj = (JArray)jo.GetValue(propertiesKey);

        foreach (var propObj in propertiesObj)
        {
            properties.Add((string)propObj);
        }
        
        return properties;
    }
     
    private static String ReadJSON()
    {
        return File.ReadAllText("E://Projects/A1QA/CSharp/PageObjectTask/DEMOQATests/Resoursces/config.json");
    } 
}