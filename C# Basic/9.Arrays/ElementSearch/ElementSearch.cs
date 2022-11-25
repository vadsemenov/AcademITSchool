using System;

namespace ElementSearch
{
    public class ElementSearch
    {
        static void Main(string[] args)
        {
            int[] array = {2, 5, 6, 7, 8, 10};

            Console.WriteLine("Индекс числа 8 - " + GetElementIndex(array, 8));

            Console.Read();
        }

        public static int GetElementIndex(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}