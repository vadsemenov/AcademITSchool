using System;

namespace PrintAndRead
{
    public class PrintRead
    {
        static void Main(string[] args)
        {
            int number1 = PrintAndRead("Введите первое число:");
            int number2 = PrintAndRead("Введите второе число:");

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            Console.Read();
        }

        private static int PrintAndRead(string message)
        {
            Console.WriteLine(message);

            return int.Parse(Console.ReadLine() ?? string.Empty);
        }
    }
}