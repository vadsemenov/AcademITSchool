using System;

namespace MaxMin
{
    public class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Вычисление с помощью оператора if-else:");

            if (number1 > number2)
            {
                Console.WriteLine($"Наибольшее число - {number1}, наименьшее число - {number2}");
            }
            else if (number1 == number2)
            {
                Console.WriteLine($"Число {number1} равно числу {number2}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число - {number2}, наименьшее число - {number1}");
            }

            Console.WriteLine();

            int maxNumber = number1 >= number2 ? number1 : number2;
            int minNumber = number1 >= number2 ? number2 : number1;

            Console.WriteLine("Вычисление с помощью тернарного оператора:");
            Console.WriteLine($"Наибольшее число - {maxNumber}, наименьшее число - {minNumber}");

            Console.Read();
        }
    }
}