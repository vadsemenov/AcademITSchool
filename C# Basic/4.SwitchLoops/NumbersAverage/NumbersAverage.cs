using System;

namespace NumbersAverage
{
    public class NumbersAverage
    {
        static void Main(string[] args)
        {
            int rangeStartNumber = 3;
            int rangeEndNumber = 17;

            double allNumbersAverageWhile = GetAllNumbersAverageWhile(rangeStartNumber, rangeEndNumber);
            double evenNumbersAverageWhile = GetEvenNumbersAverageWhile(rangeStartNumber, rangeEndNumber);

            double allNumbersAverageDoWhile = GetAllNumbersAverageDoWhile(rangeStartNumber, rangeEndNumber);
            double evenNumbersAverageDoWhile = GetEvenNumbersAverageDoWhile(rangeStartNumber, rangeEndNumber);

            Console.WriteLine("Среднее арифметическое всех чисел (While) = " + allNumbersAverageWhile);
            Console.WriteLine("Среднее арифметическое четных чисел (While) = " + evenNumbersAverageWhile);

            Console.WriteLine("Среднее арифметическое всех чисел (DoWhile) = " + allNumbersAverageDoWhile);
            Console.WriteLine("Среднее арифметическое четных чисел (DoWhile) = " + evenNumbersAverageDoWhile);

            Console.Read();
        }

        private static double GetEvenNumbersAverageDoWhile(int rangeStartNumber, int rangeEndNumber)
        {
            int i = rangeStartNumber;
            int sum = 0;
            int count = 0;

            do
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }

                i++;
            } while (i <= rangeEndNumber);

            return (double) sum / count;
        }

        private static double GetAllNumbersAverageDoWhile(int rangeStartNumber, int rangeEndNumber)
        {
            int sum = 0;
            int i = rangeStartNumber;
            int count = 0;

            do
            {
                sum += i;
                count++;
                i++;
            } while (i <= rangeEndNumber);

            return (double) sum / count;
        }

        private static double GetEvenNumbersAverageWhile(int rangeStartNumber, int rangeEndNumber)
        {
            int sum = 0;
            int i = rangeStartNumber;
            int count = 0;

            while (i <= rangeEndNumber)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }

                i++;
            }

            return (double) sum / count;
        }

        private static double GetAllNumbersAverageWhile(int rangeStartNumber, int rangeEndNumber)
        {
            int sum = 0;
            int i = rangeStartNumber;
            int count = 0;

            while (i <= rangeEndNumber)
            {
                sum += i;
                count++;
                i++;
            }

            return (double) sum / count;
        }
    }
}