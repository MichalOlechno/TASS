using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tass___military.DataProvider
{
    public static class  DataProvider
    {
        public static military_full GetCountry(string CountryName)
        {
            var countryData = new military_full();
            using (var context = new Context())
            {
                countryData=context.MilitaryContext.Where(x=>x.Country.ToLower()== CountryName.ToLower()).FirstOrDefault();
            }
            return countryData;
        }
        public static List<military_full> GetAlliesData(string CountryName)
        {
            var alliances = new List<alliance_with_duplicates>();
            var alliesData = new List<military_full>();
            using (var context = new Context())
            {
                alliances = context.AlliancesContext.Where(x => x.state_name1.ToLower() == CountryName.ToLower()).ToList();
                foreach(var ally in alliances)
                {
                    alliesData.Add(context.MilitaryContext.Where(x => x.Country.ToLower() == ally.state_name2.ToLower()).FirstOrDefault());
                }
            }
            return alliesData;
        }
        public static List<military_full> GetAllCountries()
        {
            var countries = new List<military_full>();
            using (var context = new Context())
            {
                countries = context.MilitaryContext.ToList();
            }
            return countries; 
        }
    }
}
