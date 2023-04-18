using DEMOQATests.Core;
using DEMOQATests.Elements;
using DEMOQATests.Helpers;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class IframePage : BaseForm
{
    private Button alertsButton = new Button(By.XPath("//span[text()[contains(.,'Nested Frames')]]"), "Nested frames button");
    private Button framesButton = new Button(By.XPath("//*[@id='item-2']/span[text()[contains(.,'Frames')]]"), "Frames button");
    private TextBox messageTextBox = new TextBox(By.Id("sampleHeading"), "");
    private TextBox parentMessageTextBox = new TextBox(By.Id("frame1"), "iframe1");
    private TextBox littleMessageTextBox = new TextBox(By.Id("frame2"), "iframe1");
    private TextBox elementInsideTheFrame = new TextBox(By.TagName("body"), "Element inside the first frame");
    private int childFrameIndex = 0;


    public IframePage() 
        : base(By.XPath("//div[@class = 'main-header' and contains(text(), 'Frames')]"), "Frames")
    {
    }
    
    public void GoToNestedFramesTab(){
        alertsButton.Click();
    }

    public void GoToFramesTab(){
        framesButton.Click();
    }

    public string GetMessage(int frameIndex) {
        var textBox = new TextBox(By.XPath(""), "");

        if(frameIndex == 1){
            textBox = parentMessageTextBox;
        }
        else if(frameIndex == 2){
            textBox = littleMessageTextBox;
        }

        var element = textBox.GetElement();

        FrameUtil.SwitchToFrame(element);

        var frameHeadings = messageTextBox.GetElement();
        var text = frameHeadings.Text;

        return text;
    }

    public string GetParentMessage(){
        var parentFrame = parentMessageTextBox.GetElement();

        FrameUtil.SwitchToFrame(parentFrame);

        IWebElement parentFrameElement = elementInsideTheFrame.GetElement();

        return parentFrameElement.Text;
    }



    public string GetChildMessage(){
        FrameUtil.SwitchToChildElement(childFrameIndex);

        IWebElement childrenFrameElement = elementInsideTheFrame.GetElement();

        return childrenFrameElement.Text;
    }
}