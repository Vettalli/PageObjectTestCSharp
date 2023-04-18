using System;
using DEMOQATests.Core;
using DEMOQATests.Elements;
using DEMOQATests.Helpers;
using DEMOQATests.JSONReader;
using DEMOQATests.Models;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class WebTablesPage : BaseForm
{
    private string webTablesXpath = "//span[contains(text(), 'Web Tables')]";
    private string addButtonXpath = "//button[@id = 'addNewRecordButton']";
    private string userDataFromTableXpath = "//*[text() = '%s']";
    private string deleteRecordXpath = "//span[@id = 'delete-record-4']";
    private string rowsXpath = "//div[@class = 'rt-tr-group']";
    private string cellXpath = "(//div[@class = 'rt-td'])[%d]";
    
    public WebTablesPage() 
        : base(By.XPath("//div[@class = 'main-header'  and contains(text(), 'Web Tables')]"), "Elements label")
    {
    }
    
    public void GoToWebTablesTab(){
        var alertsButton = new Button(By.XPath(webTablesXpath), "Alerts button");

        alertsButton.Click();
    }

    public void OpenRegistrationForm(){
        var addButton = new Button(By.XPath(addButtonXpath), "add button");
        addButton.Click();
    }

    public bool IsRegistrationFormClosed(){
        var addButton = new Button(By.XPath(addButtonXpath), "add button");
        return addButton.IsElementDisplayed();
    }

    public UserData GetUserDataFromTable(String id, String firstName, String lastName, String email, String age, String salary, String department){
        var firstNameEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, firstName)), "first name");
        var firstNameCurrent = firstNameEl.GetText();

        var lastNameEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, lastName)), "last name");
        var lastNameCurrent = lastNameEl.GetText();

        var emailEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, email)), "email");
        var emailCurrent = emailEl.GetText();

        var ageEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, age)), "age");
        var ageCurrent = ageEl.GetText();

        var salaryEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, salary)), "salary");
        var salaryCurrent = salaryEl.GetText();

        var departmentEl = new TextBox(By.XPath(StringUtil.GetXpathWithStringParam(userDataFromTableXpath, department)), "department");
        var departmentCurrent = departmentEl.GetText();

        return new UserData(id, firstNameCurrent, lastNameCurrent, emailCurrent, ageCurrent, salaryCurrent, departmentCurrent);
    }

    public void DeleteUser(){
        var button = new Button(By.XPath(deleteRecordXpath), "Delete button");
        button.Click();
    }

    public int GetNumberOfRows(){
        return TableUtil.CountNumberOfFilledRows(rowsXpath, cellXpath, Int32.Parse(JSONProvider.GetProperty("data", "indexDifference")));
    }
}