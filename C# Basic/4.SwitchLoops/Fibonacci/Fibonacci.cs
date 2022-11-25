using System;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            int fibonacciNumberIndex = GetNumberFromConsole("Введите номер числа Фибоначчи:");

            if (fibonacciNumberIndex == 0)
            {
                Console.WriteLine($"{fibonacciNumberIndex} число Фибоначчи равно 0");
            }
            else if (fibonacciNumberIndex == 1 || fibonacciNumberIndex == 2)
            {
                Console.WriteLine($"{fibonacciNumberIndex} число Фибоначчи равно 1");
            }
            else
            {
                int previousFibonacciNumber = 1;
                int currentFibonacciNumber = 1;
                int nextFibonacciNumber = 0;

                int i = 3;

                while (i <= fibonacciNumberIndex)
                {
                    nextFibonacciNumber = previousFibonacciNumber + currentFibonacciNumber;
                    previousFibonacciNumber = currentFibonacciNumber;
                    currentFibonacciNumber = nextFibonacciNumber;

                    i++;
                }

                Console.WriteLine($"{fibonacciNumberIndex} число Фибоначчи равно {nextFibonacciNumber}");
            }

            Console.Read();
        }

        private static int GetNumberFromConsole(string question)
        {
            Console.WriteLine(question);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result >= 0)
                    {
                        return result;
                    }

                    Console.WriteLine("Введите значение больше или равное 0! Введите снова.");
                }

                Console.WriteLine("Введено неправильное значение. Введите снова.");
            }
        }
    }
}