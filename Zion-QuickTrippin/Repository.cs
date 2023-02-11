namespace Zion_QuickTrippin
{
    public class Repository
    {
        // we're using a static list here instead of a proper database
        // but the general idea still holds up once we cover databases
        // it's just another piece of code to replace and refactor nbd
        public static List<District> _districts = new List<District>();
        public static List<Store> _stores = new List<Store>();
        public static List<Employee> _employees = new List<Employee>();
        public void LoadSampleData()
        {
            District sampleOne = new District
            {
                DistrictName = "NorthWest",
                DistrictManager = "James",
                StoreNumbers = new List<int>() { 420, 169 }
            };
            _districts.Add(sampleOne);
            District sampleTwo = new District
            {
                DistrictName = "SouthEast",
                DistrictManager = "Chase",
                StoreNumbers = new List<int>() { 063, 120 }
            };
            _districts.Add(sampleTwo);
            Store storeOne = new Store
            {
                StoreNumber = 420,
                DistrictName = "NorthWest",
                GasSales = 10000
            };
            _stores.Add(storeOne);

            Store storeTwo = new Store
            {
                StoreNumber = 169,
                DistrictName = "NorthWest",
                GasSales = 4000
            };
            _stores.Add(storeTwo);

            Store storeThree = new Store
            {
                StoreNumber = 063,
                DistrictName = "SouthEast",
                GasSales = 9000
            };
            _stores.Add(storeThree);

            Store storeFour = new Store
            {
                StoreNumber = 120,
                DistrictName = "SouthEast",
                GasSales = 8666
            };
            _stores.Add(storeFour);

            Employee employeeOne = new Employee
            {
                FirstName = "Holden",
                LastName = "Weed",
                JobTitle = "Floor maintaince engineer",
                StoreNumber = 420,
                RetailSales = 400.20
            };
            _employees.Add(employeeOne);

            Employee employeeTwo = new Employee
            {
                FirstName = "Deanna",
                LastName = "Hollifield",
                JobTitle = "Angel of death",
                StoreNumber = 169,
                RetailSales = 200.10
            };
            _employees.Add(employeeTwo);

            Employee employeeThree = new Employee
            {
                FirstName = "Chase",
                LastName = "Burnett",
                JobTitle = "Martial Arts Master",
                StoreNumber = 063,
                RetailSales = 300.20
            };
            _employees.Add(employeeThree);

            Employee employeeFour = new Employee
            {
                FirstName = "Alvin",
                LastName = "Wendt",
                JobTitle = "Master wizard of code",
                StoreNumber = 120,
                RetailSales = 60.20
            };
            _employees.Add(employeeFour);

        }
        public List<District> GetDistricts()
        {
            return _districts;
        }
        public List<Store> GetStores()
        {
            return _stores;
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}


 
   

