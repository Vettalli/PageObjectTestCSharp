using DEMOQATests.Browser;
using DEMOQATests.DEMOQA;
using DEMOQATests.Helpers;
using DEMOQATests.Tests.Base;
using NUnit.Framework;
using NUnit.Framework.Internal;
using StringUtil = DEMOQATests.Helpers.StringUtil;

namespace DEMOQATests.Tests;

public class Tests : BaseTests
{
    [Test]
    public void AlertsTest()
    {
        MainPage mainPage = new MainPage();
        AlertsFrameWindowsPage alertsPage = new AlertsFrameWindowsPage();

        var isMainPageOpen = mainPage.IsFormOpen();

        Assert.True(isMainPageOpen, "DENOQA Main page is not opened");

        mainPage.GoToAlertsFrameWindowsPage();

        Assert.True(alertsPage.IsFormOpen(), "Alerts, Frame & Windows page is not opened");

        BrowserUtil.ScrollPage();

        alertsPage.GoToAlertTab();
        alertsPage.ClickToAlertButton();

        var alertsText = AlertUtil.GetTextAlert();

        Assert.AreEqual(alertsText, "You clicked a button");

        AlertUtil.AcceptAlert();

        var isAlertActive = AlertUtil.IsAlertExist();

        Assert.False(isAlertActive, "Alert window is opened");

        alertsPage.ClickToConfirmButton();

        var alertsConfirmText = AlertUtil.GetTextAlert();

        Assert.AreEqual(alertsConfirmText, "Do you confirm action?");

        AlertUtil.AcceptAlert();

        Assert.False(AlertUtil.IsAlertExist(), "Alert window is opened");
        Assert.True(alertsPage.CheckText(), "Alert text is missing!");

        alertsPage.ClickToPromptButton();

        var alertsPromptText = AlertUtil.GetTextAlert();

        Assert.AreEqual(alertsPromptText, "Please enter your name");

        var text = AlertUtil.SendRandomTextToAlert();
        AlertUtil.AcceptAlert();

        Assert.False(AlertUtil.IsAlertExist(), "Alert window is opened");
        Assert.AreEqual(alertsPage.GetText(), "You entered "+text, "Alert text is missing!");
    }
}