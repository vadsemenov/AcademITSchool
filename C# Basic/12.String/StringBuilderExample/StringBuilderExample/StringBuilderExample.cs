using System;
using System.Text;

namespace StringBuilderExample
{
    public class StringBuilderExample
    {
        static void Main(string[] args)
        {
            StringBuilder numbersStringBuilder = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                numbersStringBuilder.Append(i).Append(", ");
            }

            numbersStringBuilder.Remove(numbersStringBuilder.Length - 2, 2);

            string numbersLine = numbersStringBuilder.ToString();

            Console.WriteLine(numbersLine);

            Console.Read();
        }
    }
}