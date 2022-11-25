using System;

namespace Rectangle
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = width * length;
            double perimeter = 2 * (width + length);

            Console.WriteLine("Длина прямоугольника    = {0:F2}" + Environment.NewLine +
                              "Ширина прямоугольника   = {1:F2}" + Environment.NewLine +
                              "Площадь прямоугольника  = {2:F2}" + Environment.NewLine +
                              "Периметр прямоугольника = {3:F2}", length, width, area, perimeter);

            Console.Read();
        }
    }
}