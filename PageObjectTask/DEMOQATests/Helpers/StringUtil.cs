using System;
using System.Text;
using DEMOQATests.JSONReader;

namespace DEMOQATests.Helpers;

public class StringUtil
{
    public static string GenerateRandomString()
    {
        var leftLimit = Int32.Parse(JSONProvider.GetProperty("data", "leftLimit"));
        var rightLimit = Int32.Parse(JSONProvider.GetProperty("data", "rightLimit"));
        var stringLength = RandomUtil.GetRandomInteger();
        var random = new Random();
        var stringBuilder = new StringBuilder("");
        int randomValue;
        char letter;

        for (int i = 0; i < stringLength; i++)
        {
            randomValue = random.Next(leftLimit, rightLimit);
            letter = Convert.ToChar(randomValue + 65);
            stringBuilder.Append(letter);
        }

        return stringBuilder.ToString();
    }
    
    public static string GetXpathWithStringParam(string xpath, string replaceStr,string param){
        var finalXPath =xpath.Replace(replaceStr, param);
         
        return finalXPath;
    }

    public static String GetXpathWithNumberParam(string xpath, string replaceStr,string param){
        var finalXPath =xpath.Replace(replaceStr, param);
         
        return finalXPath;
    }
}