using System;
using System.Collections.ObjectModel;
using DEMOQATests.Waits;
using NUnit.Framework;
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
        TestContext.Progress.WriteLine("Get element: " + elementName);
        
        return driver.FindElement(uniqueLocator);
    }
    
    public ReadOnlyCollection<IWebElement> GetElements()
    {
        TestContext.Progress.WriteLine("Get elements: " + elementName);
        
        return driver.FindElements(uniqueLocator);
    }

    public void Click()
    {
        TestContext.Progress.WriteLine("Click on " + elementName);
        
        GetElement().Click();
    }

    public bool IsElementDisplayed()
    {
        TestContext.Progress.WriteLine("Checking if element "+elementName+"displayed on the page");
        
        return GetElement().Displayed;
    }

    public String GetText()
    {
        TestContext.Progress.WriteLine("Get " + elementName +"' text");
        
        return GetElement().Text;
    }
}