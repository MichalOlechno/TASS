using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tass___military.DataProvider;
using tass___military.Models;

namespace tass___military
{
    class Program
    {
        static void Main(string[] args)
        {

            // generować min, max, avg z podanych właściwości

            string countryName = Console.ReadLine();
            var CountryData = new Country();
            var countries = DataProvider.DataProvider.GetAllCountries();
            var country = DataProvider.DataProvider.GetCountry(countryName);

            var alliancesData = DataProvider.DataProvider.GetAlliesData(country.Country);
            CountryData.MilitaryData = country;
            CountryData.AlliesData = alliancesData;
            foreach (var ally in CountryData.AlliesData)
            {
                if (ally != null)
                {
                    Console.WriteLine(ally.Country);
                }
                else
                    Console.WriteLine("NULL");
            }









            Console.ReadLine();

        }
    }
}
