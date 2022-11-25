using System;

namespace EvenNumbersAverage
{
    internal class EvenNumbersAverage
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6};

            Console.WriteLine("Среднее арифметическое четных чисел массива: " + GetArrayEvenNumbersAverage(array));

            Console.Read();
        }

        public static double GetArrayEvenNumbersAverage(int[] array)
        {
            int evenNumbersCount = 0;
            int evenNumbersSum = 0;

            foreach (int value in array)
            {
                if (value % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += value;
                }
            }

            if (evenNumbersCount == 0)
            {
                return -1;
            }

            return (double) evenNumbersSum / evenNumbersCount;
        }
    }
}