using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory continente = new AmericaFactory();
            AnimalWorld animales = new AnimalWorld(continente);
            animales.RunFoodChain();
        }
    }
}
