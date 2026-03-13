namespace Superhero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseHero[] heros = new BaseHero[3];
            heros[0] = new Warrior("hero1 ", 100, 20);
            heros[1] = new Mage("hero2 ", 80, 10);
            heros[2] = new Archer("hero3", 95, 18);
            Console.WriteLine("------------------------------------- HEROS ---------------------------------------------------");
            for (int i = 0; i < heros.Length; i++) {
                heros[i].Introduce();
            }

        }
    }
}
