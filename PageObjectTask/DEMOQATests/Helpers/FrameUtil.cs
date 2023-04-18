using OpenQA.Selenium;

namespace DEMOQATests.Helpers;

public class FrameUtil
{
    private static IWebDriver driver = Browser.Browser.GetDriver();
    
    public static void SwitchToFrame(IWebElement element)
    {
        driver.SwitchTo().Frame(element);
    }

    public static void SwitchToChildElement(int index)
    {
        driver.SwitchTo().Frame(index);
    }
}