using System;

namespace Range
{
    public class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range(-10.2, 10.2);

            range.From = -20.2;
            range.To = 40.5;

            Console.WriteLine("Длина диапазона равна" + range.GetLength());

            Console.WriteLine("Введите значение:");
            double value = double.Parse(Console.ReadLine() ?? string.Empty);

            if (range.IsInside(value))
            {
                Console.WriteLine("Число находится в диапазоне.");
            }
            else
            {
                Console.WriteLine("Число вне диапазона.");
            }

            Console.Read();
        }
    }
}