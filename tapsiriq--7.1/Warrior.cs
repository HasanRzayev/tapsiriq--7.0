using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._1
{
    internal class Warrior : Unit
    {
        public Warrior(string name, int defense, int attack, int health) : base(name, defense, attack, health)
        {
        }

        public override void LetsAttack()
        {
            Console.WriteLine("Warrior attack ");
        }

        public override void LetsDie()
        {
            Console.WriteLine("Warrior oldu ");
        }

        public override void LetsRetreat()
        {
            Console.WriteLine("Warrior retreat ");
        }
    }
}
