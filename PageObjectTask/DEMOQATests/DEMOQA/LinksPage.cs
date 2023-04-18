using DEMOQATests.Core;
using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class LinksPage : BaseForm
{
    private Button homeButton = new Button(By.XPath("//a[@id = 'simpleLink']"), "Home button");
    
    public LinksPage() 
        : base(By.XPath("//div[@class = 'main-header'  and contains(text(), 'Links')]"), "Links page")
    {
    }
    
    public void GoToHomePage(){
        homeButton.Click();
    }
}