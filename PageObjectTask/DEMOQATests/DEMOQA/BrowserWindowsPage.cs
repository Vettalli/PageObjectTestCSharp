using DEMOQATests.Core;
using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class BrowserWindowsPage : BaseForm
{
    private Button newTabButton = new Button(By.XPath("//button[@id = 'tabButton']"), "New tab button");
    private TextBox textSampleTextBox = new TextBox(By.XPath("//*[@id = 'sampleHeading']"), "Sample page");
    private Button elementsButton = new Button(By.XPath("(//div[@class = 'header-wrapper'])[1]"), "Elements button");
    private Button linksButton = new Button(By.XPath("//*[@id='item-5']/span[text()[contains(.,'Links')]]"), "Links button");

    
    public BrowserWindowsPage() 
        : base(By.XPath("//div[@class = 'main-header' and contains(text(), 'Browser Windows')]"), "Browser Windows Page")
    {
    }
    
    public void OpenNewTab(){
        newTabButton.Click();
    }

    public bool IsNewTabOpened(){
        return textSampleTextBox.IsElementDisplayed();
    }

    public void OpenElements(){
        elementsButton.Click();
    }

    public void GoToLinksTab(){
        linksButton.Click();
    }
}