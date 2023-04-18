using System;
using DEMOQATests.JSONReader;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DEMOQATests.Waits;

public class ConditionalWait
{
    private static WebDriverWait wait;
    private static readonly int timeOutInSeconds = Int32.Parse(JSONProvider.GetProperty("config" ,"timeOutInSeconds"));

    public static WebDriverWait GetWaits()
    {
        if (wait == null)
        {
            wait = new WebDriverWait(Browser.Browser.GetDriver(), TimeSpan.FromSeconds(timeOutInSeconds));
        }

        return wait;
    }

    public static IWebElement WaitToBeClickcable(By locator)
    {
        return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
    }

    public static IWebElement WaitForElementPresented(By locator)
    {
        return wait.Until(ExpectedConditions.ElementExists(locator));
    }
}