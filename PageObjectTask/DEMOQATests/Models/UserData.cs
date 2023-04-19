using Newtonsoft.Json;

namespace DEMOQATests.Models;

public class UserData
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }
    
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }
    
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }
    
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }
    
    [JsonProperty(PropertyName = "age")]
    public string Age { get; set; }
    
    [JsonProperty(PropertyName = "salary")]
    public string Salary { get; set; }
    
    [JsonProperty(PropertyName = "department")]
    public string Department { get; set; }

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