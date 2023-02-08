namespace Zion_QuickTrippin;

public class Store
{
    public string StoreNumber { get; set; }
    public int DistrictNumber { get; set; }
    public int GasSales { get; set; }

    public List<Store> CreateStore(string StoreNumber, int DistrictNumber, int GasSales)
    {
        Console.WriteLine("Please provide new store number");
        string enteredNumber = Console.ReadLine();

    }
}
