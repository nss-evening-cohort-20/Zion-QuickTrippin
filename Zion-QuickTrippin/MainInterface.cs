using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Zion_QuickTrippin;

public class MainInterface
{
    
    public MainInterface()
    {
        _repository = new Repository();
        _createStore = new Store();
        _createEmployee = new Employee();
        _createDistrict = new District();
    }
    
    public Repository _repository;
    public Store _createStore;
    public Employee _createEmployee;
    public District _createDistrict;


    public bool Running = true;

    public void Show()
    {
        _repository.LoadSampleData();

        while (Running)
        {
            List<District> DistrictList = _repository.RepoDistricts;
            List<Store> StoreList = _repository.RepoStores;
            List<Employee> EmployeeList = _repository.RepoEmployees;

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
                var newDistrict = _createDistrict.CreateDistrict();
                _repository.AddDistrict(newDistrict);
                
            } else if (numericInput == 2)
            {
                var newStore = _createStore.CreateStore();
                _repository.AddStores(newStore);

            } else if (numericInput == 3)
            {
                var newEmployee = _createEmployee.CreateEmployee();
                _repository.AddEmployees(newEmployee);

            } else if (numericInput == 4)
            {
                Console.WriteLine("Adding district");
            } else if (numericInput == 5)
            {
                Console.WriteLine("Adding district");
            } else if (numericInput == 6)
            {
                Running = false;
            }
        }
    }

    public void InputSales()
    {
        List<Store> StoreList = _repository.RepoStores;
        List<Employee> EmployeeList = _repository.RepoEmployees;
        //select store
        Console.WriteLine("Please select the store of your choosing.");

        //loop through stores
        foreach (var store in StoreList)
        {
            Console.WriteLine($"{store.StoreNumber}");
        }
        
        string numberInput = Console.ReadLine();
        int storeNumber = Convert.ToInt32(numberInput);

        var FilteredEmployees = EmployeeList.Where(x => x.StoreNumber == storeNumber);


        //set gas sales
        Console.WriteLine("What are your gas gales?");

        string gasSalesInput = Console.ReadLine();
        double gasSalesAmt = Convert.ToDouble(gasSalesInput);   

        
        
        //Loop over each employee and set sales
       
    }
}
