using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using DVLDDataAccessLayer;
namespace DVLDBusinessLogicLayer
{
    public class clsCountries
    {
        public static DataTable GetAllCountries()
        {
            return DVLDDataAccessLayer.clsCountriesDataAccess.GetAllCountries();
        }

        public static bool GetCountry(int ID, ref string CountryName)
        {
            return DVLDDataAccessLayer.clsCountriesDataAccess.GetCountry(ID, ref CountryName);
        }

        public static bool GetCountry(ref int ID,string CountryName)
        {
            return DVLDDataAccessLayer.clsCountriesDataAccess.GetCountry(ref ID,CountryName);
        }

    }
}
