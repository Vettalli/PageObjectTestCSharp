using System;
using System.Collections.Generic;
using DEMOQATests.Browser;
using DEMOQATests.DEMOQA;
using DEMOQATests.Helpers;
using DEMOQATests.JSONReader;
using DEMOQATests.Models;
using DEMOQATests.Tests.Base;
using NUnit.Framework;

namespace DEMOQATests.Tests;

public class Tests : BaseTests
{
    [Test]
    public void AlertsTest()
    {
        JSONProvider.GetUserData();
        
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
    
    [Test]
    public void FrameTest(){
        MainPage mainPage = new MainPage();
        IframePage iframePage = new IframePage();

        var isMainPageOpen = mainPage.IsFormOpen();

        Assert.True(isMainPageOpen, "DENOQA Main page is not opened");

        mainPage.GoToAlertsFrameWindowsPage();

        BrowserUtil.ScrollPage();

        iframePage.GoToNestedFramesTab();

        var isNestedFramesPageOpen = iframePage.IsFormOpen();

        Assert.True(isNestedFramesPageOpen, "Nested Frames page is not opened");

        var parentMessage = iframePage.GetParentMessage();
        var childMessage = iframePage.GetChildMessage();

        Assert.AreNotEqual("", parentMessage, "There are not messages presented on the page");
        Assert.AreNotEqual("", childMessage, "There are not messages presented on the page");

        BrowserUtil.RefreshPage();
        BrowserUtil.ScrollPage();

        iframePage.GoToFramesTab();

        var isFramesPageOpen = iframePage.IsFormOpen();

        Assert.True(isFramesPageOpen, "Frames page is not opened");

        var indexForFrame1 = 1;
        var indexForFrame2 = 2;

        BrowserUtil.RefreshPage();

        var message1 = iframePage.GetMessage(indexForFrame1);

        BrowserUtil.RefreshPage();

        var message2 = iframePage.GetMessage(indexForFrame2);

        Assert.AreEqual(message2, message1);
    }

    // [Test, TestCaseSource(nameof(TestData))]
    // public void TablesTest(UserData userData)
    // {
    //     
    // }
    
    // private static IEnumerable<Object[]> TestData(){
    //     return JSONProvider.GetUserData();
    // }
}