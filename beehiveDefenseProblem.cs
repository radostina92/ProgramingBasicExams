using System;

namespace Zadacha05
{
    class beehiveDefenseProblem
    {
        static void Main(string[] args)
        {
            int bee = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());
         
            int healThBee = 0;
            bool chek = false;

            for (int i = bee; i >= 0; i--)
            {
                bee = bee - attack;
                health = health - bee * 5;
                
                if (bee < 0)
                {
                    bee = 0;
                }
                    if (health <= 0)
                    {
                        Console.WriteLine($"Beehive won! Bees left {bee}.");
                        chek = true;
                        break;

                    }
                    if (bee < 100)
                    {
                    
                        Console.WriteLine($"The bear stole the honey! Bees left {bee}.");
                        chek = true;
                        break;
                    }
                   

               

               

                if (chek)
                {
                    break;
                }
        
            }
          
        }
    }
}
