using System;

namespace Palindrome
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string userString = Console.ReadLine();

            if (IsPalindrome(userString))
            {
                Console.WriteLine("Строка - Палиндром!");
            }
            else
            {
                Console.WriteLine("Строка не палиндром!");
            }

            Console.Read();
        }

        private static bool IsPalindrome(string line)
        {
            if (line == null)
            {
                throw new ArgumentNullException(nameof(line), "Строка - null!");
            }

            if (line.Length == 0)
            {
                return true;
            }

            line = line.ToUpper();

            for (int i = 0, j = line.Length - 1; i <= j; i++, j--)
            {
                while (!char.IsLetter(line[i]) && i < j)
                {
                    i++;
                }

                while (!char.IsLetter(line[j]) && i < j)
                {
                    j--;
                }

                if (i > j)
                {
                    break;
                }

                if (line[i] != line[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}