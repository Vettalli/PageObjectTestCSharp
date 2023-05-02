using System;
using System.IO;
using WebDriverManager.DriverConfigs.Impl;

namespace DEMOQATests.Helpers;

public class Logger
{
    private static string logFile = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
    private static StreamWriter stream = null;
    
    public static void CreateLogFile()
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, @"LogFile");

        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(filePath);
        }
        
        stream = File.AppendText(filePath + logFile + ".log");
    }

    public static void WriteToFile(string message)
    {
        stream.Write("{0} {1}\t", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
        stream.Write("\\T{0}", message);
        stream.Flush();
    }
}