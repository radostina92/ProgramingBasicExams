using System;

namespace zadacha06
{
    class examResults
    {
        static void Main(string[] args)
        {
            string command = "";

            
            
            while ((command = Console.ReadLine()) != "Midnight")
            {
                double sum = 0;
                double sumCnt = 0;
                double newSum = 0;
                double totalSum = 0;
                double grade = 0;
                int points = 0;
                
                for (int i = 1; i <= 6; i++)
                {
                   

                     points = int.Parse(Console.ReadLine());
                    sumCnt++;
                    if (points < 0)
                    {
                        Console.WriteLine($"{command} was cheating!");
                       
                        break;
                    }

                    sum += points;
                    newSum = sum * 1.00 / (sumCnt * 100);
                    totalSum = Math.Floor(newSum * 100);
                    grade = totalSum * 0.06;

                   
                     
                }
                 if (points < 0)
                {
                    continue;
                }
              
              
                if (grade >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {grade:f2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {command}");
                }

                else if (grade >= 3)
                {
                   Console.WriteLine($"{command} - {grade:f2}");
                }
                else if (grade < 3)
                {
                    Console.WriteLine($"{command} - 2.00");
                }


            }
        }
    }
}
