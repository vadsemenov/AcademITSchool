using System;

namespace StringSplit
{
    public class StringSplit
    {
        static void Main(string[] args)
        {
            string line = "1, 2, 3, 4, 5";

            string[] numbersStringsArray = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbersArray = new int[numbersStringsArray.Length];

            int sum = 0;

            for (int i = 0; i < numbersStringsArray.Length; i++)
            {
                int number = Convert.ToInt32(numbersStringsArray[i]);

                numbersArray[i] = number;

                sum += number;
            }

            Console.WriteLine("Сумма чисел строки: " + sum);

            Console.Read();
        }
    }
}