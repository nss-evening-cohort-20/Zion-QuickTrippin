namespace Zion_QuickTrippin;

public class Store
{
    public string StoreNumber { get; set; }
    public string DistrictName { get; set; }
    public int GasSales { get; set; }

    //string StoreNumber, int DistrictNumber, int GasSales
    public Store CreateStore()
    {
        Store store = new Store();

        Console.WriteLine("Please provide new store number");
        string enteredNumber = Console.ReadLine();
        store.StoreNumber = enteredNumber;

        Console.WriteLine("Please choose a district");
        //this is where the district list would show up (loop WriteLine of the district name property

        string enteredDistrict = Console.ReadLine();

        store.DistrictName = enteredDistrict;

        store.GasSales = 0;

        //add store to list in repository class 
        return(store);

    }
}
