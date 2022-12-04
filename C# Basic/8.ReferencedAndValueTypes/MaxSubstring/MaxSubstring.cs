using System;

namespace MaxSubstring
{
    public class MaxSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string userString = Console.ReadLine();

            int maxCharRepetitionsCount = GetCharMaxRepetitionsAmount(userString);

            Console.WriteLine($"Символ максимально повторяется {maxCharRepetitionsCount} количество раз.");

            Console.Read();
        }

        private static int GetCharMaxRepetitionsAmount(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return 0;
            }

            line = line.ToUpper();

            int maxCharRepetitionsAmount = 1;
            int currentCharRepetitionsAmount = 1;

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i - 1] == line[i])
                {
                    currentCharRepetitionsAmount++;
                }
                else
                {
                    if (maxCharRepetitionsAmount < currentCharRepetitionsAmount)
                    {
                        maxCharRepetitionsAmount = currentCharRepetitionsAmount;
                    }

                    currentCharRepetitionsAmount = 1;
                }
            }

            if (maxCharRepetitionsAmount < currentCharRepetitionsAmount)
            {
                maxCharRepetitionsAmount = currentCharRepetitionsAmount;
            }

            return maxCharRepetitionsAmount;
        }
    }
}