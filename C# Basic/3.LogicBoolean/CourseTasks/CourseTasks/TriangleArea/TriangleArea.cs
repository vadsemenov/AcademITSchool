using System;

namespace TriangleArea
{
    public class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение площади треугольника.");

            double x1 = GetNumberFromConsole("Введите координату X1:");
            double y1 = GetNumberFromConsole("Введите координату Y1:");
            double x2 = GetNumberFromConsole("Введите координату X2:");
            double y2 = GetNumberFromConsole("Введите координату Y2:");
            double x3 = GetNumberFromConsole("Введите координату X3:");
            double y3 = GetNumberFromConsole("Введите координату Y3:");

            double epsilon = 1.0e-10;

            if (Math.Abs((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) <= epsilon)
            {
                Console.WriteLine("Точки лежат на одной прямой.");
                Console.Read();

                return;
            }

            Console.WriteLine($"Площадь треугольника равна: {GetTriangleArea(x1, y1, x2, y2, x3, y3)}");

            Console.Read();
        }

        private static double GetTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double sideALength = GetTriangleSideLength(x1, y1, x2, y2);
            double sideBLength = GetTriangleSideLength(x2, y2, x3, y3);
            double sideCLength = GetTriangleSideLength(x3, y3, x1, y1);

            double semiPerimeter = (sideALength + sideBLength + sideCLength) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideALength) * (semiPerimeter - sideBLength) *
                             (semiPerimeter - sideCLength));
        }

        private static double GetTriangleSideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static double GetNumberFromConsole(string question)
        {
            double result;

            do
            {
                Console.WriteLine(question);
            } while (!double.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}