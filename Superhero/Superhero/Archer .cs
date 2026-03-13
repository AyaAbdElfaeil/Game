using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Archer : BaseHero
    {
        public Archer(string name, int health, int power) : base(name, health, power)
        {

        }
        
        public override void Attack()
        {
            Console.WriteLine("Archer  Attack .....");
        }

    }
}
