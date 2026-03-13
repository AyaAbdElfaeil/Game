using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal abstract  class BaseHero
    {
        
            private  string name { get;  set; }
            private int health { get;  set; }
            private int power { get; set; }
            
            public BaseHero(string name, int health, int power)
            {
                this.name = name;
                this.health = health;
                this.power = power;
            }



            public abstract void Attack();

            public void Introduce()
            {
                Console.WriteLine($" I`m :   {name}  , Health :   {health}  H , Power :  {power}  ");

            }
            public void heal()
            {
                health += 10;
                Console.WriteLine($"{name} Healed  10 H ........... ");
            }  public void heal(int am )
            {
                if (am > 0)
                {
                    health += am;
                    Console.WriteLine($"{name} Healed  {am} H ........... ");
                }
            }



        
    }
}
