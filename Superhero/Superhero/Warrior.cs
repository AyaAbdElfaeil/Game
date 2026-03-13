using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Warrior: BaseHero
    {
        public Warrior(string name, int health, int power) : base(name, health, power)
        {

        }
        public string type = " Warrior";
        public override void Attack()
        {
            Console.WriteLine("Warrior Attack .....");
        }

    }
}
