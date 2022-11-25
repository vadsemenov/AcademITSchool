using System;

namespace Password
{
    public class Password
    {
        static void Main(string[] args)
        {
            const string password = "qwerty";

            Console.WriteLine("Введите пароль:");
            string passwordFromConsole = Console.ReadLine();

            if (password.Equals(passwordFromConsole))
            {
                Console.WriteLine("Пароль верный");
            }
            else if (passwordFromConsole.Length > password.Length)
            {
                Console.WriteLine("Пароль неверный. Строка слишком длинная.");
            }
            else if (passwordFromConsole.Length < password.Length)
            {
                Console.WriteLine("Пароль неверный. Строка слишком короткая.");
            }
            else
            {
                Console.WriteLine("Пароль неверный.");
            }

            Console.Read();
        }
    }
}