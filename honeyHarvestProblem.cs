using System;

namespace Zadacha03
{
    class honeyHarvestProblem
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int cntFlowers = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            if (season == "Summer")
            {
                if (flower == "Sunflower")
                {
                    price = 8;
                }
                else if (flower == "Daisy")
                {
                    price = 8;
                }
                else if (flower == "Lavender")
                {
                    price = 8;

                }
                else if (flower == "Mint")
                {
                    price = 12;
                }
            }
            else if (season == "Spring")
            {
                if (flower == "Sunflower")
                {
                    price = 10;
                }
                else if (flower == "Daisy")
                {
                    price = 12;
                    price = price + (price * 0.10);
                }
                else if (flower == "Lavender")
                {
                    price = 12;

                }
                else if (flower == "Mint")
                {
                    price = 10;
                    price = price + (price * 0.10);
                }
            }
            else if (season == "Autumn")
            {
                if (flower == "Sunflower")
                {
                    price = 12;
                }
                else if (flower == "Daisy")
                {
                    price = 6;
                }
                else if (flower == "Lavender")
                {
                    price = 6;

                }
                else if (flower == "Mint")
                {
                    price = 6;
                }
            }
            double sum = price * cntFlowers;
            if (season == "Summer")
            {
                sum = sum + (sum * 0.10);
            }
            if (season == "Autumn")
            {
                sum = sum - (sum * 0.05);
            }

            Console.WriteLine($"Total honey harvested: {sum:f2}");

        }
    }
}
