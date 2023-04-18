using System;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace DEMOQATests.Helpers;

public class AlertUtil
{
    private static IWebDriver driver = Browser.Browser.GetDriver();

    public static void AcceptAlert(){
        driver.SwitchTo().Alert().Accept();
    }

    public static string GetTextAlert()
    {
        return driver.SwitchTo().Alert().Text;
    }

    public static bool IsAlertExist(){
        try
        {
            driver.SwitchTo().Alert();
            return true;
        }
        catch (NoAlertPresentException Ex)
        {
            return false;
        }
    }

    public static string SendRandomTextToAlert(){
        var text = StringUtil.GenerateRandomString();
        driver.SwitchTo().Alert().SendKeys(text);

        return text;
    }
}