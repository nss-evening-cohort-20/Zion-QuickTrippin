namespace Zion_QuickTrippin;

public class MainInterface
{
    public MainInterface() 
    {
        _createStore = new Store();
        _createEmployee = new Employee();
    }
    public Store _createStore;
    public Employee _createEmployee;
    public bool Running = true;
    public void Show()
    { 
    while (Running)
	{
            Console.WriteLine("Management Interface");
            Console.WriteLine(@"
1. Add New District
2. Add New Store
3. Add New Employee
4. Input Store Sales
5. Generate District Report
6. Exit");
            string inputText = Console.ReadLine();
            int numericInput = 0;
            bool IsNumber = int.TryParse(inputText, out numericInput);
            while (IsNumber != true || numericInput <= 0 || numericInput >= 7)
            {
                Console.WriteLine("Please enter a valid number.");
                inputText = Console.ReadLine();
                IsNumber = int.TryParse(inputText, out numericInput);
            }

            if (numericInput == 1)
            {
                Console.WriteLine("Adding district");
            } else if (numericInput == 2) 
            {
                _createStore.CreateStore();
            } else if (numericInput == 3) 
            {
                _createEmployee.CreateEmployee();
            } else if (numericInput == 4) 
            {
                Console.WriteLine("Adding district");
            } else if (numericInput == 5)
            {
                Console.WriteLine("Adding district");
            } else if (numericInput == 6) 
            {
               Running= false;
            }
	}
}
}
