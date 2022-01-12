using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._1
{
    internal class Viking:Unit
    {
        public Viking(string name, int defense, int attack, int health) : base(name, defense, attack, health)
        {
        }

        public override void LetsAttack()
        {
            Console.WriteLine("Viking attack ");
        }

        public override void LetsDie()
        {
            Console.WriteLine("Viking died ");
        }

        public override void LetsRetreat()
        {
            Console.WriteLine("Viking retreat ");
        }
    }
}
