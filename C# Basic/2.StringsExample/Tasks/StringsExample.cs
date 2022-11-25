using System;

namespace StringsExample
{
    public class StringsExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is" + Environment.NewLine +
                              "few strings ");

            Console.WriteLine("\"30\" августа 1903г." + Environment.NewLine +
                              "C:\\Windows\\System32\\Drivers\\etc\\hosts");

            int sum = 4 + 5;
            string result = "Результат = " + sum;
            Console.WriteLine(result);
        }
    }
}