using System;

namespace Palindrome
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string userString = Console.ReadLine();

            if (IsPalindromeString(userString))
            {
                Console.WriteLine("Строка - Палиндром!");
            }
            else
            {
                Console.WriteLine("Строка не палиндром!");
            }

            Console.Read();
        }

        private static bool IsPalindromeString(string line)
        {
            if (string.IsNullOrEmpty(line) || line.Length < 1)
            {
                return false;
            }

            line = line.ToUpper();

            int j = line.Length - 1;

            bool isComparisonHave = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (!char.IsLetter(line[i]))
                {
                    i++;
                }

                if (!char.IsLetter(line[j]))
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
                else
                {
                    isComparisonHave = true;
                }

                j--;
            }

            return isComparisonHave;
        }
    }
}