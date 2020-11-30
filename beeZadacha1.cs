using System;

namespace beeZadacha1
{
    class beeZadacha1
    {
        static void Main(string[] args)
        {
            int bee = int.Parse(Console.ReadLine());
            int flowers = int.Parse(Console.ReadLine());

            decimal honey = bee * flowers * 0.21m;
            decimal result = Math.Floor(honey / 100);


            decimal heu = result * 100;
            decimal news = honey - heu;

            Console.WriteLine(result);
            Console.WriteLine(news);
        }
    }
}
