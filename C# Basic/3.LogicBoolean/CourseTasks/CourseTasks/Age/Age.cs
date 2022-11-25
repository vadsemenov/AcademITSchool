using System;

namespace Age
{
    public class Age
    {
        static void Main(string[] args)
        {
            int age = GetNumberFromConsole("Введите свой возраст от 1 до 112 лет:");

            if (age < 1)
            {
                Console.WriteLine("Вы слишком малы!");
                Console.Read();

                return;
            }

            if (age > 112)
            {
                Console.WriteLine("Вы слишком стары!");
                Console.Read();

                return;
            }

            int ageLastDigit = age % 10;
            int ageLast2Digits = age % 100;

            if (ageLastDigit == 0 || ageLastDigit >= 5 || (ageLast2Digits >= 11 && ageLast2Digits <= 14))
            {
                Console.WriteLine($"Вам {age} лет.");
            }
            else if (ageLastDigit == 1)
            {
                Console.WriteLine($"Вам {age} год.");
            }
            else
            {
                Console.WriteLine($"Вам {age} года.");
            }

            Console.Read();
        }

        private static int GetNumberFromConsole(string question)
        {
            int result;

            do
            {
                Console.WriteLine(question);
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}