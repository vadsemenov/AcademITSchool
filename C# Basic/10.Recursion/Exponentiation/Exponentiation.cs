using System;

namespace Exponentiation
{
    public class Exponentiation
    {
        static void Main(string[] args)
        {
            int number = GetIntNumberFromConsole("Введите число больше или равное 0:");
            int power = GetIntNumberFromConsole("Введите степень числа. Число большее или равное 0:");

            Console.WriteLine("Результат рекурсивного вычисления: " + GetNumberExponentiationRecursive(number, power));
            Console.WriteLine("Результат не рекурсивного вычисления: " + GetNumberExponentiation(number, power));
            Console.Read();
        }

        private static int GetNumberExponentiationRecursive(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            if (power == 1)
            {
                return number;
            }

            return number * GetNumberExponentiationRecursive(number, power - 1);
        }

        private static int GetNumberExponentiation(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            var result = 1;

            while (power > 0)
            {
                result *= number;
                power -= 1;
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