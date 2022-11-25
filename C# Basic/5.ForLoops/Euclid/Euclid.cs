using System;

namespace Euclid
{
    public class Euclid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение НОД.");

            Console.WriteLine("Введите первое число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == 0 && number2 == 0)
            {
                Console.WriteLine("Оба числа равны нулю. НОД нет.");

                return;
            }

            while (true)
            {
                if (number2 == 0)
                {
                    break;
                }

                number1 %= number2;

                int tempNumber = number1;
                number1 = number2;
                number2 = tempNumber;
            }

            Console.WriteLine("НОД равен " + number1);

            Console.Read();
        }
    }
}