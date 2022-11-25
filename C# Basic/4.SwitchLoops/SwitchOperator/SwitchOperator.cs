using System;

namespace SwitchOperator
{
    public class SwitchOperator
    {
        static void Main(string[] args)
        {
            int number1 = GetNumberFromConsole("Введите первое число:");
            int number2 = GetNumberFromConsole("Введите второе число:");
            int commandCode = GetNumberFromConsole("Введите код команды, 1-сложение чисел, 2-вычитание чисел, 3-умножение чисел, 4-деление чисел:");

            switch (commandCode)
            {
                case 1:
                    Console.WriteLine($"Сумма равна: {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"Разность равна: {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"Произведение равно: {number1 * number2}");
                    break;
                case 4:
                    Console.WriteLine($"Частное чисел: {(double) number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;
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