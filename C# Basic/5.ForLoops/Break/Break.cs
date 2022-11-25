using System;

namespace Break
{
    public class Break
    {
        static void Main(string[] args)
        {
            string hiddenString = "hidden string";

            while (true)
            {
                Console.WriteLine("Введите строку:");
                string userString = Console.ReadLine();

                if (userString == hiddenString)
                {
                    Console.WriteLine("Строка угадана!");
                    break;
                }

                Console.WriteLine("Строка не угадана!");
            }

            Console.Read();
        }
    }
}