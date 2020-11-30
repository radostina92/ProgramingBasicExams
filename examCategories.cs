using System;

namespace zadacha03
{
    class examCategories
    {
        static void Main(string[] args)
        {
            int complicated = int.Parse(Console.ReadLine());
            int round = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            string type = "";
            if (complicated >= 80 && round <= 10 && pages > 0)
            {
                type = "Master";
            }
           else  if (complicated >= 80 && round >= 80 && pages >= 8)
            {
                type = "Legacy";
            }
            else if (round >= 50 && pages >= 2 && complicated > 0)
            {
                type = "Hard";
            }

            else if (complicated <= 30 && pages <= 1 && round > 0)
            {
                type = "Easy";

            }
            else if (complicated <= 10 && round > 0 && pages > 0)
            {
                type = "Elementary";

            }
           
            else if (complicated > 0 && round > 0 && pages > 0)
            {
                type = "Regular";
            }
            Console.WriteLine(type);
        }
    }
}
