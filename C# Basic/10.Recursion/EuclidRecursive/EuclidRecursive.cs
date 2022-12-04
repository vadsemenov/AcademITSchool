using System;

namespace EuclidRecursive
{
    public class EuclidRecursive
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

            Console.WriteLine("НОД равен " + GetGreatestCommonDivisor(number1, number2));

            Console.Read();
        }

        public static int GetGreatestCommonDivisor(int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }

            return GetGreatestCommonDivisor(number2, number1 % number2);
        }
    }
}