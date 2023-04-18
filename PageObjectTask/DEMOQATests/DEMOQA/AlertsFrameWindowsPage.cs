using DEMOQATests.Core;
using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class AlertsFrameWindowsPage : BaseForm
{
    private Button browserWindowsButton = new Button(By.XPath("//span[contains(text(), 'Browser Windows')]"), "Browser windows button");
    private Button alertsButton = new Button (By.XPath("//span[contains(text(), 'Alerts')]"),"Alerts button");
    private Button alertButton = new Button(By.XPath("//button[@id = 'alertButton']"), "Alert Button");
    private Button confirmButton = new Button(By.XPath("//button[@id = 'confirmButton']"), "Confirm Button");
    private Button promptButton = new Button(By.XPath("//button[@id = 'promtButton']"), "Prompt Button");
    private TextBox promptResultsTextBox = new TextBox(By.XPath("//span[@id = 'promptResult']"), "Confirm result text");
    private TextBox confirmResultTextBox = new TextBox(By.XPath("//span[@id = 'confirmResult']"), "Confirm result text");
    
    public AlertsFrameWindowsPage() 
        : base(By.XPath("//div[@class = 'main-header'  and contains(text(), 'Alerts, Frame & Windows')]")
            , "Alerts, Frame & Windows Page")
    {}

    public void GoToBrowserWindowsTab()
    {
        browserWindowsButton.Click();
    }

    public void GoToAlertTab()
    {
        alertsButton.Click();
    }
    
    public void ClickToAlertButton(){
        alertButton.Click();
    }

    public void ClickToConfirmButton(){
        confirmButton.Click();
    }

    public void ClickToPromptButton(){
        promptButton.Click();
    }

    public string GetText(){
        return promptResultsTextBox.GetText();
    }

    public bool CheckText(){
        return confirmResultTextBox.IsElementDisplayed();
    }
}