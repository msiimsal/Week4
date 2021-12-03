using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit vaid ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Paku number välja:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitja!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number! {3 - i} katsete arvu on jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
