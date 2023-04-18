using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using DEMOQATests.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DEMOQATests.JSONReader;

public static class JSONProvider
{
    public static string GetProperty(string type ,string propertyKey)
    {
        string json = ReadJSON(type);
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

    public static List<string> GetProperties(string type ,string propertiesKey)
    {
        List<string> properties = new List<string>();
        String json = ReadJSON(type);
        JObject jo = JObject.Parse(json);
        JArray propertiesObj = (JArray)jo.GetValue(propertiesKey);

        foreach (var propObj in propertiesObj)
        {
            properties.Add((string)propObj);
        }
        
        return properties;
    }
    
    public static void GetUserData()
    {
        var json = ReadJSON("userData");
        var user = JsonConvert.DeserializeObject<UserData[]>(json);

        int t = 5;
    }
     
    private static String ReadJSON(string type)
    {
        string json = "";
        
        switch (type)
        {
            case "config":
                json = File.ReadAllText(@"E:\Projects\A1QA\CSharp\PageObjectTestCSharp\PageObjectTask\DEMOQATests\Resoursces\config.json");
                break;
            case "data":
                json = File.ReadAllText(@"E:\Projects\A1QA\CSharp\PageObjectTestCSharp\PageObjectTask\DEMOQATests\Resoursces\data.json");
                break;
            case "userData":
                json = File.ReadAllText(@"E:\Projects\A1QA\CSharp\PageObjectTestCSharp\PageObjectTask\DEMOQATests\Resoursces\userData.json");
                break;
        }
        
        return json;
    }
}