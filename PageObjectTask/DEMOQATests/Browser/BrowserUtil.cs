using DEMOQATests.JSONReader;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace DEMOQATests.Browser;

public static class BrowserUtil
{
    private static IWebDriver driver;
    
    public static IWebDriver SetUpDriver()
    {
        ChromeOptions options = new ChromeOptions();
        var chromeOptions = JSONProvider.GetProperties("chromeOptions");

        foreach (var option in chromeOptions)
        {
            options.AddArgument(option);
        }
        
        driver = new ChromeDriver(options);

        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

        return driver;
    }

    public static void SetMaximumWindowSize()
    {
        driver.Manage().Window.Maximize();
    }

    public static void RefreshPage()
    {
        driver.Navigate().Refresh();
    }

    public static void ScrollPage()
    {
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
        jsExecutor.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
    }
}