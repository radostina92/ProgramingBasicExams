using System;
using System.Diagnostics.CodeAnalysis;

namespace Zadacha06
{
    class honeyWinterReserves
    {
        static void Main(string[] args)
        {
            double honey = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double totalSum = 0;

            while (name != "Winter has come")
            {
                double sum = 0;
                for (int i = 1; i <= 6; i++)
                {
                    double beeHoney = double.Parse(Console.ReadLine());
                    sum += beeHoney;
                    totalSum += beeHoney;
                    if (sum < 0)
                    {
                        Console.WriteLine($"{name} was banished for gluttony");
                    }

                }
                name = Console.ReadLine();
            }

            if (totalSum >= honey)
            {
                double diff = totalSum - honey;
                Console.WriteLine($"Well done! Honey surplus {diff:f2}.");
            }
            else
            {
                double newDiff = honey - totalSum;
                Console.WriteLine($"Hard Winter! Honey needed {newDiff:f2}.");
            }
        }
    }
}
