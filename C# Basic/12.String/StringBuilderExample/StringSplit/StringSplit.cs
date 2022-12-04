using System;

namespace StringSplit
{
    public class StringSplit
    {
        static void Main(string[] args)
        {
            string line = "1, 2, 3, 4, 5";

            string[] numbersArray = line.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (var numberInString in numbersArray)
            {
                if (int.TryParse(numberInString, out int number))
                {
                    sum += number;
                }
            }

            Console.WriteLine("Сумма чисел строки: " + sum);

            Console.Read();
        }
    }
}