namespace Zion_QuickTrippin;

public class Employee
{
    public string FirstName { get; set; }  
    public string LastName { get; set; }
    public string JobTitle { get; set; }

    public Employee(string firstName, string lastName, string jobTitle)
    {
        FirstName = firstName;
        LastName = lastName;
        JobTitle = jobTitle;
    }

    public string EmployeeName => $"{FirstName} {LastName}";



    
}
