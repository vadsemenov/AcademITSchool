using System;
using System.Text;

namespace StringBuilderExample
{
    public class StringBuilderExample
    {
        static void Main(string[] args)
        {
            StringBuilder numbers = new StringBuilder();

            numbers.Append("1");

            for (int i = 2; i <= 100; i++)
            {
                numbers.Append(",");
                numbers.Append(i.ToString());
            }

            Console.WriteLine(numbers.ToString());

            Console.Read();
        }
    }
}