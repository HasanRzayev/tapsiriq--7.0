using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq__7._1
{
    abstract class Unit
    {
        protected Unit(string name, int defense, int attack, int health)
        {
            this.name = name;
            this.defense = defense;
            this.attack = attack;
            this.health = health;
        }

        public string name { get; set; }
        public int defense { get; set; }
        public int attack { get; set; }
        public int health { get; set; }

        abstract public void LetsAttack();
        abstract public void LetsDie();
        abstract public void LetsRetreat();
        public void Show()
        {
            Console.WriteLine("Name----"+name);
            Console.WriteLine("Defense----"+ defense);
            Console.WriteLine("Attack----"+ attack);
            Console.WriteLine("Heath----"+ health);
        }

    }
}
