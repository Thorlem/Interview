using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intern.Models;

namespace Intern.Services
{
    public class CountryService
    {
        public static List<Country> countries { get; set; }

        public static void loadData()
        {

            countries = new List<Country>
            {
                new Country("CAN", 10, "Canada", new List<string> {"USA"}),
                new Country("USA", 20, "United State", new List<string> {"CAN", "MEX"}),
                new Country("MEX", 30, "Mexico", new List<string> {"USA", "GTM", "BLZ"}),
                new Country("GTM", 40, "Guatemala", new List<string> {"MEX", "BLZ", "SLV", "HND"}),
                new Country("BLZ", 45, "Belize", new List<string> {"MEX", "GTM"}),
                new Country("SLV", 55, "El Salvador", new List<string> {"HND", "GTM"}),
                new Country("HND", 50, "Honduras", new List<string> {"SLV", "GTM", "NIC"}),
                new Country("NIC", 60, "Nicaragua", new List<string> {"HND", "CRI"}),
                new Country("CRI", 70, "Costa Rica", new List<string> {"NIC", "PAN"}),
                new Country("PAN", 80, "Panama", new List<string> {"CRI"})
            };

        }
    }
}
