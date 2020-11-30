using System;

namespace zadacha05
{
    class examPreparation
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int zadacha = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int zadaci = 0;
            int questions = 0;
            int questEner = 0;
            int newStudents = 0;
            int cnt = 0;
            int razbivka = 0;
            while (true)
            {
                zadaci = zadacha * 2;
                energy += zadaci;
                students -= zadacha;
                cnt += zadacha;
                questions += students * 2;
                razbivka = students * 2;
                questEner = razbivka * 3;
                energy -= questEner;

                if (students >= 10)
                {
                    newStudents = students / 10;
                    students += newStudents;
                    
                }
                else
                {
                    Console.WriteLine($"The students are too few!");
                    Console.WriteLine($"Problems solved: {cnt}");
                    break;
                }
             
                if (energy <= 0)
                {
                    Console.WriteLine($"The trainer is too tired!");
                    Console.WriteLine($"Questions asked: {questions}");
                    break;

                }
            }
        }
    }
}
