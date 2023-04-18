using DEMOQATests.Core;
using DEMOQATests.Elements;
using OpenQA.Selenium;

namespace DEMOQATests.DEMOQA;

public class RegistrationFormPage : BaseForm
{
    private Input firstNameInput = new Input(By.XPath("//input[@id = 'firstName']"), "First name");
    private Input lastNameInput = new Input(By.XPath("//input[@id = 'lastName']"), "Last name");
    private Input emailInput = new Input(By.XPath("//input[@id = 'userEmail']"), "Email");
    private Input ageInput = new Input(By.XPath("//input[@id = 'age']"), "Age");
    private Input salaryInput = new Input(By.XPath("//input[@id = 'salary']"), "Salary");
    private Input departmentInput = new Input(By.XPath("//input[@id = 'department']"), "Department");
    private Button submitButton = new Button(By.XPath("//button[@id = 'submit']"), "Submit");
    
    public RegistrationFormPage()
        : base(By.XPath("//div[@id = 'registration-form-modal']"), "Registration form page")
    {
    }
    
    public void FillFirstNameField(string firstName){
        firstNameInput.SendKeys(firstName);
    }

    public void FillLastNameField(string lastName){
        lastNameInput.SendKeys(lastName);
    }

    public void FillEmailField(string email){
        emailInput.SendKeys(email);
    }

    public void FillAgeField(string age){
        ageInput.SendKeys(age);
    }

    public void FillSalaryField(string salary){
        salaryInput.SendKeys(salary);
    }

    public void FillDepartmentField(string department){
        departmentInput.SendKeys(department);
    }

    public void ClickSubmitButton(){
        submitButton.Click();
    }
}