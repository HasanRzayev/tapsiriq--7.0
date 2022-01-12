using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._0
{
    class CountryArray
    {
        public Country[] countries = new Country[] {};
        public void Add(Country c)
        {
            Array.Resize(ref countries, countries.Length + 1);
            countries[countries.Length - 1] = c;
        }
        public Country this[int i1]
        {
            get => countries[i1];
            set => countries[i1] = value;
        }
        public void Show()
        {
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"================{i+1}============");
                countries[i].Show();
                Console.WriteLine($"================{i+1}============");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");

            }
        }
    }
}
