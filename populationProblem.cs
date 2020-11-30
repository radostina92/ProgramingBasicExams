using System;

namespace Zadacha04
{
    class populationProblem
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            int newBee = 0;
            int deadBee = 0;
            int diff = 0;
            int bee = 0;
            int popi = 0;
            int veche = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 5 == 0)
                {
                    bee = population / 10 * 2;
                    newBee = bee + population;
                    popi = newBee / 50 * 5;
                    bee = newBee - popi;
                    deadBee = newBee / 20 * 2;
                    diff = popi - deadBee;
                    population += diff;
                }
                else
                {
                    bee = population / 10 * 2;
                    newBee = bee + population;
                    deadBee = newBee / 20 * 2;
                    diff = bee - deadBee;
                    population += diff;

                }




            }
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
