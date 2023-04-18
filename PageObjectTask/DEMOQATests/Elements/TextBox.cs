using DEMOQATests.Core;
using OpenQA.Selenium;

namespace DEMOQATests.Elements;

public class TextBox : BaseElement
{
    public TextBox(By uniqueLocator, string elementName) : base(uniqueLocator, elementName)
    {
    }
}