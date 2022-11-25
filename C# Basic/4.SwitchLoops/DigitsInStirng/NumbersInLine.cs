using System;

namespace NumbersInLine
{
    public class NumbersInLine
    {
        static void Main(string[] args)
        {
            int startNumber = GetNumberFromConsole("Введите начальное число:");
            int endNumber = GetNumberFromConsole("Введите конечное число:");
            int lineNumbersMaxAmount = GetNumberFromConsole("Введите количество чисел в строке:");

            int lineNumberAmount = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i,10}");
                lineNumberAmount++;

                if (lineNumberAmount == lineNumbersMaxAmount)
                {
                    lineNumberAmount = 0;
                    Console.WriteLine();
                }
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
                    return result;
                }

                Console.WriteLine("Введено неправильное значение. Введите еще раз.");
            }
        }
    }
}