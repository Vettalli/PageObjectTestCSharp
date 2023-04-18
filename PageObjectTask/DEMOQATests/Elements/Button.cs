using DEMOQATests.Core;
using OpenQA.Selenium;

namespace DEMOQATests.Elements;

public class Button : BaseElement
{
    public Button(By uniqueLocator, string elementName) : base(uniqueLocator, elementName)
    {
    }
}