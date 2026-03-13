using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Mage : BaseHero
    {
        public Mage(string name, int health, int power) : base(name, health, power)
        {

        }
        public string type = " Mage";
        public override void Attack()
        {
            Console.WriteLine("Mage  Attack .....");
        }

    }
}
