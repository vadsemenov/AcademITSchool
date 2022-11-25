using System;

namespace MaxSubstring
{
    public class MaxSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string userString = Console.ReadLine();

            var maxCharRepetitionsCount = GetMaxRepeatCharCount(userString);

            Console.WriteLine($"Символ максимально повторяется {maxCharRepetitionsCount} количество раз.");

            Console.Read();
        }

        private static int GetMaxRepeatCharCount(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return 0;
            }

            line = line.ToUpper();

            int maxRepeatCharAmount = 1;
            int currentCharRepetitionsAmount = 1;

            for (int i = 1; i < line.Length; i++)
            {
                char previousChar = line[i - 1];

                if (previousChar == line[i])
                {
                    currentCharRepetitionsAmount++;
                }
                else
                {
                    if (maxRepeatCharAmount < currentCharRepetitionsAmount)
                    {
                        maxRepeatCharAmount = currentCharRepetitionsAmount;
                    }

                    currentCharRepetitionsAmount = 1;
                }
            }

            if (maxRepeatCharAmount < currentCharRepetitionsAmount)
            {
                maxRepeatCharAmount = currentCharRepetitionsAmount;
            }

            return maxRepeatCharAmount;
        }
    }
}