using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.HashSet
{
    public class CountriesTracker
    {
        public void CheckHasCountries()
        {
            HashSet<string> countries = new HashSet<string> { "JAPAN", "USA", "AUSTRALIA", "CANADA", "CHINA", "RUSSIA", "FRANCE" };

            Console.WriteLine("List of countries: ");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("Does HashSet contain USA?");
            Console.WriteLine(countries.Contains("USA"));
            Console.WriteLine("Does HashSet contain England?");
            Console.WriteLine(countries.Contains("ENGLAND"));
        }
    }
}
