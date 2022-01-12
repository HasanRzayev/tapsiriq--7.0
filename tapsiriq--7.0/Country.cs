using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._0
{
    class Country
    {
        public Country(string countryName, string cityName, int population)
        {
            CountryName = countryName;
            CityName = cityName;
            this.population = population;
        }
        public void Show()
        {
            Console.WriteLine("Country name---"+CountryName);
            Console.WriteLine("City name---"+CityName);
            Console.WriteLine("Country population---"+population);
        }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public int population { get; set; }
        public static bool operator <(Country p, Country p1)
        {
            if (p.population < p1.population) return true;   
            return false;
        }
        public static bool operator >(Country p, Country p1)
        {
            if (p.population > p1.population) return true;
            return false;
        }

        public static bool operator ==(Country p, Country p1)
        {
            if (p.population == p1.population) return true;
            return false;
        }
        public static bool operator !=(Country p, Country p1)
        {
            if (p.population != p1.population) return true;
            return false;
        }
    }
}
