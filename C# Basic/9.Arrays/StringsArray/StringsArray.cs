using System;

namespace StringsArray
{
    public class StringsArray
    {
        static void Main(string[] args)
        {
            string[] array = {"first", "second", "third"};

            ChangeStringsToUpperCase(array);

            Console.WriteLine("Значение элементов массива в верхнем регистре: " + string.Join(", ", array));

            Console.Read();
        }

        public static void ChangeStringsToUpperCase(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToUpper();
            }
        }
    }
}