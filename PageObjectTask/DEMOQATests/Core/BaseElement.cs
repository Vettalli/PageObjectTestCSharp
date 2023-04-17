using System;
using System.Collections.ObjectModel;
using DEMOQATests.Waits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEMOQATests.Core;

public abstract class BaseElement
{
    private By uniqueLocator;
    private string elementName;
    private IWebDriver driver;
    private WebDriverWait wait;

    protected BaseElement(By uniqueLocator, string elementName)
    {
        this.uniqueLocator = uniqueLocator;
        this.elementName = elementName;
        driver = Browser.Browser.GetDriver();
        wait = ConditionalWait.GetWaits();
    }

    public IWebElement GetElement()
    {
        return driver.FindElement(uniqueLocator);
    }
    
    public ReadOnlyCollection<IWebElement> GetElements()
    {
        return driver.FindElements(uniqueLocator);
    }

    public void Click()
    {
        GetElement().Click();
    }

    public bool IsElementDisplayed()
    {
        return GetElement().Displayed;
    }

    public String GetText()
    {
        return GetElement().Text;
    }
}