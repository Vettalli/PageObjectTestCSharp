using DEMOQATests.Core;
using OpenQA.Selenium;

namespace DEMOQATests.Elements;

public class Input : BaseElement
{
    public Input(By uniqueLocator, string elementName) : base(uniqueLocator, elementName)
    {
    }

    public void SendKeys(string keys)
    {
        GetElement().Click();
        GetElement().SendKeys(keys);
    }
}