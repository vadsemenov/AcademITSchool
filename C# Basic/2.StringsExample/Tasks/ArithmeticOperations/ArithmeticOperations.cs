using System;

namespace ArithmeticOperations
{
    public class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 5;

            double x = 9d;
            double y = 3d;

            Console.WriteLine("a+b= " + (a + b));
            Console.WriteLine("a-b= " + (a - b));
            Console.WriteLine("a*b= " + (a * b));
            Console.WriteLine("a/b= " + (a / b));
            Console.WriteLine("a%b= " + (a % b));

            Console.WriteLine("x+y= " + (x + y));
            Console.WriteLine("x-y= " + (x - y));
            Console.WriteLine("x*y= " + (x * y));
            Console.WriteLine("x/y= " + (x / y));
            Console.WriteLine("x%y= " + (x % y));

            Console.Read();
        }
    }
}