using System;

namespace HelloWorld
{
    public class Calculate
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 6;

            int result = a + b * c + 56 / a;

            Console.WriteLine($"The answer of equation is {result}.");
            Console.Read();
        }
    }
}