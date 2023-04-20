using System;
using OpenQA.Selenium;

namespace DEMOQATests.Helpers;

public class TabUtil
{
    private static IWebDriver driver = Browser.Browser.GetDriver();
    
    public static void SwitchToChildTab()
    {
        string mainWindow = driver.CurrentWindowHandle;
        string childWindow = "";

        var windows = driver.WindowHandles;

        foreach (var window in windows) {
            if(window != mainWindow){
                childWindow = window;
            }
        }

        driver.SwitchTo().Window(childWindow);
    }

    public static void SwitchToParentTab(){
        String mainWindow = driver.CurrentWindowHandle;

        var windows = driver.WindowHandles;

        foreach (var window in windows) {
            if(window != mainWindow){
                mainWindow = window;
                driver.Close();

                break;
            }
        }

        driver.SwitchTo().Window(mainWindow);
    }
}