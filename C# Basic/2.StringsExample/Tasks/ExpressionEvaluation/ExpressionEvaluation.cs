using System;

namespace ExpressionEvaluation
{
    // Задача на дом «Вычисление выражений»
    public class ExpressionEvaluation
    {
        static void Main(string[] args)
        {
            double x = 3 - ((56 - 12) / 44) * (4 / 2);

            double y = (2 * x) / (33 - x);

            double z = -x / (2 * y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            Console.Read();
        }
    }
}