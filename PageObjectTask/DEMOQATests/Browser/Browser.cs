using DEMOQATests.JSONReader;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DEMOQATests.Browser;

public static class Browser
{
    private static IWebDriver driver;

    public static IWebDriver GetDriver()
    {
        if (driver == null)
        {
            driver = BrowserUtil.SetUpDriver();
        }

        return driver;
    }

    public static void GoToUrl()
    {
        TestContext.Progress.WriteLine("Get Url");
        
        driver.Url = JSONProvider.GetProperty("config" ,"url");
    }

    public static void StopDriverBrowser()
    {
        TestContext.Progress.WriteLine("Stop Browser's driver");
        
        driver.Quit();
        driver = null;
    }
}