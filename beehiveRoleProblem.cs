using System;

namespace Zadacha02
{
    class beehiveRoleProblem
    {
        static void Main(string[] args)
        {
            int intelect = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (intelect >= 80 && power >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (intelect >= 80)
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (power >= 80 && gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (intelect >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            
            else if (power >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");
            }
        }
    }
}
