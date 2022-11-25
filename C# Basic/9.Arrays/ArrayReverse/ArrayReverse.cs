using System;

namespace ArrayReverse
{
    public class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

            ReverseArray(array);

            Console.WriteLine("Массив после разворота: " + string.Join(" ", array));

            Console.Read();
        }

        public static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1 - i; i++)
            {
                int tempValue = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tempValue;
            }
        }
    }
}