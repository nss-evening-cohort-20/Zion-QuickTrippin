using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zion_QuickTrippin
{
    public class District
    {

        //Properties
        public string DistrictName { get; set; }
        public string DistrictManager { get; set; }
        public List<int> StoreNumbers { get; set; }

        //Constructor
        public District CreateDistrict ()
        {
            District district = new District ();
            Console.WriteLine("What is the name of the new district?");
            string enteredName = Console.ReadLine();
            district.DistrictName = enteredName;

            Console.WriteLine("Who is the district manager?");
            
            string districtManager = Console.ReadLine();
            district.DistrictManager = districtManager;

            district.StoreNumbers= new List<int> ();

            return(district);
        }


    }
}
