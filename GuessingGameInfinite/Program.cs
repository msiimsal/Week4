using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit vaid ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Paku number välja:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitja!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale number! Proovi uuesti!");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
