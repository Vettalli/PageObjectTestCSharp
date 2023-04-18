using Newtonsoft.Json;

namespace DEMOQATests.Models;

public class UserData
{
    [JsonProperty(PropertyName = "id")]
    private string Id { get; set; }
    
    [JsonProperty(PropertyName = "firstName")]
    private string FirstName { get; set; }
    
    [JsonProperty(PropertyName = "lastName")]
    private string LastName { get; set; }
    
    [JsonProperty(PropertyName = "email")]
    private string Email { get; set; }
    
    [JsonProperty(PropertyName = "age")]
    private string Age { get; set; }
    
    [JsonProperty(PropertyName = "salary")]
    private string Salary { get; set; }
    
    [JsonProperty(PropertyName = "department")]
    private string Department { get; set; }

    public UserData(string id, string firstName, string lastName, string email, string age, string salary, string department)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        Salary = salary;
        Department = department;
    }
}