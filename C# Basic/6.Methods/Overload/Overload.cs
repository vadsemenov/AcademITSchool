using System;

namespace Overload
{
    public class Overload
    {
        public static void Main(string[] args)
        {
            byte byteVariable = byte.MinValue;
            Console.WriteLine($"Размер byte - {GetTypeSize(byteVariable)} байт");

            short shortVariable = short.MaxValue;
            Console.WriteLine($"Размер short - {GetTypeSize(shortVariable)} байта");

            int intVariable = int.MaxValue;
            Console.WriteLine($"Размер int - {GetTypeSize(intVariable)} байта");

            long longVariable = long.MaxValue;
            Console.WriteLine($"Размер long - {GetTypeSize(longVariable)} байт");

            float floatVariable = float.MaxValue;
            Console.WriteLine($"Размер float - {GetTypeSize(floatVariable)} байта");

            double doubleVariable = double.MaxValue;
            Console.WriteLine($"Размер double - {GetTypeSize(doubleVariable)} байт");

            Console.ReadLine();
        }

        private static int GetTypeSize(byte variable)
        {
            return 1;
        }

        private static int GetTypeSize(short variable)
        {
            return 2;
        }

        private static int GetTypeSize(int variable)
        {
            return 4;
        }

        private static int GetTypeSize(long variable)
        {
            return 8;
        }

        private static int GetTypeSize(float variable)
        {
            return 4;
        }

        private static int GetTypeSize(double variable)
        {
            return 8;
        }
    }
}