using System;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double coefficientA = GetNumberFromConsole("Введите коэффициент а:");
            double coefficientB = GetNumberFromConsole("Введите коэффициент b:");
            double coefficientC = GetNumberFromConsole("Введите коэффициент c:");

            double epsilon = 1.0e-10;

            if (Math.Abs(coefficientA) <= epsilon)
            {
                if (Math.Abs(coefficientB) <= epsilon)
                {
                    if (Math.Abs(coefficientC) <= epsilon)
                    {
                        Console.WriteLine("Равенство верное. Корень - любое число.");
                    }
                    else
                    {
                        Console.WriteLine("Неверное равенство. Корней нет.");
                    }

                    Console.Read();

                    return;
                }

                double x = -coefficientC / coefficientB;

                Console.WriteLine($"Линейное уравнение. x = {x}");

                Console.Read();

                return;
            }

            double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;

            if (discriminant < -epsilon)
            {
                Console.WriteLine("Корней нет.");
            }
            else if (Math.Abs(discriminant) <= epsilon)
            {
                double x = -coefficientB / (2 * coefficientA);

                Console.WriteLine($"У уравнения 1 корень x = {x}");
            }
            else
            {
                double x1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                double x2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);

                Console.WriteLine($"У уравнения 2 корня x1 = {x1}, x2 = {x2}");
            }

            Console.Read();
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