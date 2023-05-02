using DEMOQATests.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DEMOQATests.Elements;

public class Input : BaseElement
{
    public Input(By uniqueLocator, string elementName) : base(uniqueLocator, elementName)
    {
    }

    public void SendKeys(string keys)
    {
        TestContext.Progress.WriteLine("Send keys to element "+GetElement());
        
        GetElement().Click();
        GetElement().SendKeys(keys);
    }
}