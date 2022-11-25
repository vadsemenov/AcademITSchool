using System;

namespace NumberDigits
{
    public class NumberDigits
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromConsole("Введите число:");

            int allDigitsSum = 0;
            int oddDigitsSum = 0;
            int maxDigit = 0;

            int decimalPlaceDivisor = 10;

            while (number * 10 >= decimalPlaceDivisor)
            {
                int digit = (number % decimalPlaceDivisor * 10) / decimalPlaceDivisor;

                allDigitsSum += digit;

                if (digit % 2 != 0)
                {
                    oddDigitsSum += digit;
                }

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }

                decimalPlaceDivisor *= 10;
            }

            Console.WriteLine("Сумма цифр числа равна " + allDigitsSum);
            Console.WriteLine("Сумма нечетных цифр числа равна " + oddDigitsSum);
            Console.WriteLine("Максимальная цифра в числе " + maxDigit);

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