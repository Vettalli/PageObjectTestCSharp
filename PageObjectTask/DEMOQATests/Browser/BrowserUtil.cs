using DEMOQATests.JSONReader;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace DEMOQATests.Browser;

public static class BrowserUtil
{
    private static IWebDriver driver;
    
    public static IWebDriver SetUpDriver()
    {
        TestContext.Progress.WriteLine("Set up driver");
        
        ChromeOptions options = new ChromeOptions();
        var chromeOptions = JSONProvider.GetProperties("config" ,"chromeOptions");

        foreach (var option in chromeOptions)
        {
            options.AddArgument(option);
        }
        
        driver = new ChromeDriver(options);

        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

        return driver;
    }

    public static string GetCurrentUrl()
    {
        return driver.Url;
    }

    public static void SetMaximumWindowSize()
    {
        driver.Manage().Window.Maximize();
    }

    public static void RefreshPage()
    {
        TestContext.Progress.WriteLine("Refresh page");
        
        driver.Navigate().Refresh();
    }

    public static void ScrollPage()
    {
        TestContext.Progress.WriteLine("Scroll page");
        
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
        jsExecutor.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
    }
}