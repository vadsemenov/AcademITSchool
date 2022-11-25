using System;

namespace Greetings
{
    public class Greetings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}!");

            Console.Read();
        }
    }
}