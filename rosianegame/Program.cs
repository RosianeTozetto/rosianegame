using rosianegame.entities;
using System;


namespace rosianegame
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Personagem Hero = new Personagem("Benedictus", 27, "Archer");
            Personagem Villian = new Personagem("Lutero", 17, "Mestre");
            Personagem Monster = new Personagem("Enio", 13, "Ghost");
            Personagem Samurai = new Personagem("jackie", 16, "Ninja");

            Console.WriteLine(Hero);
            Console.WriteLine(Hero.Attack());
            Console.WriteLine(Villian);
            Console.WriteLine(Villian.Attack());
            Console.WriteLine(Monster.Attack());
            Console.WriteLine(Samurai);
            

        }
    }
}
