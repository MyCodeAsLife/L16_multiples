using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 27;
            int minNumberOfCheck = 100;
            int maxNumberOfCheck = 1000;
            int countOfMultipleNumbers = 0;
            int someNumber = random.Next(minNumber, maxNumber + 1);

            for (int i = 0; i < maxNumberOfCheck; i += someNumber)
            {
                if (i >= minNumberOfCheck)
                    ++countOfMultipleNumbers;
            }

            Console.WriteLine($"Количество трехзначных чисел кратных {someNumber}, составляет {countOfMultipleNumbers}\n");
        }
    }
}