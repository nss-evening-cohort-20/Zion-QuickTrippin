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
        District(string enteredDistrictName, string enteredDistrictManager, List<int> enteredStoreNumbers)
        {
            DistrictName = enteredDistrictName;
            DistrictManager = enteredDistrictManager;
            StoreNumbers = enteredStoreNumbers;
        }


    }
}
