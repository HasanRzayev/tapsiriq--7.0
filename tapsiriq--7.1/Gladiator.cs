using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._1
{
    internal class Gladiator:Unit
    {
        public Gladiator(string name, int defense, int attack, int health) : base(name, defense, attack, health)
        {
        }

        public override void LetsAttack()
        {
            Console.WriteLine("Gladiator attack ");
        }

        public override void LetsDie()
        {
            Console.WriteLine("Gladiator died ");
        }

        public override void LetsRetreat()
        {
            Console.WriteLine("Gladiator retreat ");
        }
    }
}
