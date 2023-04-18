using DEMOQATests.Core;
using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class MainPage : BaseForm
{
    private Button alertsFrameWindowsButton = new Button(By.XPath("//div[contains(@class, 'card')]//*[contains(text(), 'Alerts, Frame & Windows')]"), "Alerts, Frame & Windows button");
    private Button elementsButton = new Button(By.XPath("//div[contains(@class, 'card')]//*[contains(text(), 'Elements')]"), "Elements button");
    
    public MainPage() : base(By.XPath("//img[@class = 'banner-image']"), "Main page")
    {
    }
    
    public void GoToAlertsFrameWindowsPage(){
        alertsFrameWindowsButton.Click();
    }

    public void GoToElementsPage(){
        elementsButton.Click();
    }
}