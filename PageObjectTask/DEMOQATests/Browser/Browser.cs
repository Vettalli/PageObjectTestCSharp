using DEMOQATests.JSONReader;
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
        driver.Url = JSONProvider.GetProperty("config" ,"url");
    }

    public static void StopDriverBrowser()
    {
        driver.Quit();
        driver = null;
    }
}