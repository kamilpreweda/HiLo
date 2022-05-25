using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLo
{
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;

        private static Random random = new Random();

        private static int currentNumber = random.Next(1, MAXIMUM + 1);

        private static int nextNumber = random.Next(1, MAXIMUM + 1);

        private static int pot = 10;

        public static int GetPot() { return pot; }
       

        public static void Guess(bool higher)
        {
            
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                pot++;
                Console.WriteLine($"\nZgadłeś! Pula wynosi teraz {GetPot()}");
                
            }
            else
            {
                pot--;
                Console.WriteLine($"\nNiestety, błędna odpowiedź. Pula wynosi teraz {GetPot()}");
                
            }
            currentNumber = nextNumber;
            nextNumber = random.Next(1, MAXIMUM + 1);
            Console.WriteLine($"Aktualna liczba to: {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;

            if (nextNumber >= half) Console.WriteLine($"Liczba wynosi co najmniej {half}");
            else Console.WriteLine($"Liczba jest mniesza niż {half}");
            pot--;
            
                
                
           
        }
    }
}
