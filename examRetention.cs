using System;

namespace zadacha04
{
    class examRetention
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());
            double exams = 0;
            double newSuccseed = 0;
            double succseed = 0;
            double sum = 0;
            for (int i = 1; i <= seasons; i++)
            {
                if (i % 3 == 0)
                {
                    exams = Math.Ceiling(students * 90 / 100);
                    succseed = Math.Ceiling(exams * 90 / 100);
                    newSuccseed = Math.Ceiling(succseed * 80 / 100);
                    sum = Math.Ceiling (newSuccseed * 15 / 100);
                    students = newSuccseed + sum;
                }
                else
                {
                    exams = Math.Ceiling(students * 90 / 100);
                    succseed = Math.Ceiling(exams * 90 / 100);
                    newSuccseed = Math.Ceiling(succseed * 80 / 100);
                    sum = Math.Ceiling(newSuccseed * 5 / 100);
                    students = newSuccseed + sum;
                }

               

            }
            Console.WriteLine($"Students: {students}");
        }
    }
}
