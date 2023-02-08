using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zion_QuickTrippin
{
    public class Repository
    {
        // we're using a static list here instead of a proper database
        // but the general idea still holds up once we cover databases
        // it's just another piece of code to replace and refactor nbd

         public static List<District> _districts = new List<District>();

        public static District LoadSampleData()
        {
            District output = new District("Northwest",{ "201", "202", "203" });
        }


        public List<District> GetDistricts()
        {
            return _districts; 
        }

        public void SaveNewDistrict(District _district)
        {
            
        }
    }

    class StoreRepository
    {

        static List<Store> _stores = new List<Store>();

        public List<Store> GetStores();

    {
        throw new NotImplementedException();
    }

}
}
