using System.ComponentModel;
using DEMOQATests.Browser;
using DEMOQATests.Waits;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DEMOQATests.Core;

public class BaseForm
{
    private By uniqueLocator;
    private string formName;

    public BaseForm(By uniqueLocator, string formName)
    {
        this.uniqueLocator = uniqueLocator;
        this.formName = formName;
    }

    public bool IsFormOpen()
    {
        TestContext.Progress.WriteLine("Check if form "+formName+" is opened");
        
        return ConditionalWait.WaitForElementPresented(uniqueLocator).Displayed;
    }
}