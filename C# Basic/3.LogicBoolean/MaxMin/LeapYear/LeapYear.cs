using System;

namespace LeapYear
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("Високосный год.");
            }
            else
            {
                Console.WriteLine("Невисокосный год.");
            }

            Console.Read();
        }
    }
}