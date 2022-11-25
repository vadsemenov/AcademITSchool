using System;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int endNumber = GetNumberFromConsole("Введите число больше 1, до которого искать простые цифры:");

            for (int i = 2; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.Read();
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetNumberFromConsole(string question)
        {
            Console.WriteLine(question);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result > 1)
                    {
                        return result;
                    }

                    Console.WriteLine("Ошибка! Введите число больше 1");
                }
            }
        }
    }
}