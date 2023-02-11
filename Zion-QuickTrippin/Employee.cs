namespace Zion_QuickTrippin;

public class Employee
{
    public string FirstName { get; set; }  
    public string LastName { get; set; }
    public string JobTitle { get; set; }
    public int StoreNumber { get; set; }
    public double RetailSales { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    //public Employee(string firstName, string lastName, string jobTitle)
    //{
    //    FirstName = firstName;
    //    LastName = lastName;
    //    JobTitle = jobTitle;
    //}
    public Employee CreateEmployee()
    {
        Employee employee = new Employee();

        Console.WriteLine("What is the employees first name?");
        string firstName = Console.ReadLine();
        employee.FirstName = firstName;

        Console.WriteLine("What is the employees last name?");
        string lastName = Console.ReadLine();
        employee.LastName = lastName;

        Console.WriteLine("What is the employees job title?");
        string jobTitle = Console.ReadLine();
        employee.JobTitle = jobTitle;

        Console.WriteLine("Which store number would you like to add this employee too?");
        string input = Console.ReadLine();
        int numberInput = Convert.ToInt32(input);
        employee.StoreNumber = numberInput;
        //add employee to store list
        //or to employee list i dont know which one 
        employee.RetailSales = 0;
        return (employee);
    }


}
