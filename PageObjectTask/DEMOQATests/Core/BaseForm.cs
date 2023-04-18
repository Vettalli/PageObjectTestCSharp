using System.ComponentModel;
using DEMOQATests.Browser;
using DEMOQATests.Waits;
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
        return ConditionalWait.WaitForElementPresented(uniqueLocator).Displayed;
    }
}