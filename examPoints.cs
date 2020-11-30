using System;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

namespace zadacha02
{
    class examPoints
    {
        static void Main(string[] args)
        {
            int zadacha = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double coeficient = 0;
            switch (name)
            {
                case "Basics":
                    switch (zadacha)
                    {
                        case 1:
                            coeficient = 0.08;
                            break;
                        case 2:
                        case 3:
                            coeficient = 0.09;
                            break;
                        case 4:
                            coeficient = 0.10;
                            break;
                    }
                    break;
                case "Fundamentals":
                    switch (zadacha)
                    {
                        case 1:
                        case 2:
                            coeficient = 0.11;
                            break;
                        case 3:
                            coeficient = 0.12;
                            break;
                        case 4:
                            coeficient = 0.13;
                            break;
                    }
                    break;
                case "Advanced":
                    switch (zadacha)
                    {
                        case 1:
                        case 2:
                            coeficient = 0.14;
                            break;
                        case 3:
                            coeficient = 0.15;
                            break;
                        case 4:
                            coeficient = 0.16;
                            break;
                    }
                    break;
            }

            double newPoints = points * coeficient;

            if (name == "Advanced")
            {
                newPoints += newPoints * 0.20;
            }

            if (zadacha == 1 && name == "Basics")
            {
                newPoints -= newPoints * 0.20;
            }
            Console.WriteLine($"Total points: {newPoints:f2}");
        }
    }
}
