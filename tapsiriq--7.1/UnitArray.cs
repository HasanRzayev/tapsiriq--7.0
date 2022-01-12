using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._1
{
    internal class UnitArray
    {
        public Unit[] units = new Unit[] { };
        public void Add(Unit c)
        {
            Array.Resize(ref units, units.Length + 1);
            units[units.Length - 1] = c;
        }
        public Unit this[int i1]
        {
            get => units[i1];
            set => units[i1] = value;
        }
        public void Show()
        {
            for (int i = 0; i < units.Length; i++)
            {
                Console.WriteLine($"================{i + 1}============");
                units[i].Show();
                Console.WriteLine($"================{i + 1}============");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------");

            }
        }
    }
}
