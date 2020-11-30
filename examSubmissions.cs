using System;

namespace exam13._06
{
    class examSubmissions
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int zadachi = int.Parse(Console.ReadLine());

            double newZadachi = students * Math.Ceiling(zadachi * 2.8);
            int diff = students * (zadachi / 3);
            double sum = newZadachi + diff;

            double memory = 5 * Math.Ceiling(sum / 10);

            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{sum} submissions");


        }
    }
}
