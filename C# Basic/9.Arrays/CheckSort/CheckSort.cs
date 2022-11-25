using System;

namespace CheckSort
{
    public class CheckSort
    {
        static void Main(string[] args)
        {
            int[] array1 = {1, 2, 3, 4, 5, 6};
            int[] array2 = {6, 5, 4, 3, 2, 1};

            Console.WriteLine("Массив 1: " + string.Join(" ", array1));
            Console.WriteLine("Массив 2: " + string.Join(" ", array2));
            Console.WriteLine("Массив 1 упорядочен по возрастанию: " + IsSortByAscending(array1));
            Console.WriteLine("Массив 2 упорядочен по возрастанию: " + IsSortByAscending(array2));
            Console.WriteLine("Массив 1 упорядочен по убыванию: " + IsSortByDescending(array1));
            Console.WriteLine("Массив 2 упорядочен по убыванию: " + IsSortByDescending(array2));

            Console.Read();
        }

        public static bool IsSortByAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsSortByDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}