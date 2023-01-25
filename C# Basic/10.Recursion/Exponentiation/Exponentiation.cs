using System;

namespace Exponentiation
{
    public class Exponentiation
    {
        static void Main(string[] args)
        {
            int number = GetIntNumberFromConsole("Введите число больше или равное 0:");
            int power = GetIntNumberFromConsole("Введите степень числа. Число большее или равное 0:");

            Console.WriteLine("Результат рекурсивного вычисления: " + RaiseNumberToPowerRecursive(number, power));
            Console.WriteLine("Результат не рекурсивного вычисления: " + RaiseNumberToPower(number, power));
            Console.Read();
        }

        private static int RaiseNumberToPowerRecursive(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            return number * RaiseNumberToPowerRecursive(number, power - 1);
        }

        private static int RaiseNumberToPower(int number, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        private static int GetIntNumberFromConsole(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Введите число больше или равное 0:");

                        continue;
                    }

                    return result;
                }

                Console.WriteLine("Не удалось распознать число. Введите снова:");
            }
        }
    }
}