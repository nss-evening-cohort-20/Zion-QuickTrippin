namespace Zion_QuickTrippin;

public class Store
{
    public int StoreNumber { get; set; }
    public string DistrictName { get; set; }
    public double GasSales { get; set; }

    //string StoreNumber, int DistrictNumber, double GasSales
    public Store CreateStore()
    {
        Store store = new Store();

        Console.WriteLine("Please provide new store number");
        int input = Convert.ToInt32(Console.ReadLine());
        store.StoreNumber = input;

        Console.WriteLine("Please choose a district");
        //this is where the district list would show up (loop WriteLine of the district name property

        string enteredDistrict = Console.ReadLine();

        store.DistrictName = enteredDistrict;

        store.GasSales = 0;

        //add store to list in repository class 
        return(store);

    }
}
