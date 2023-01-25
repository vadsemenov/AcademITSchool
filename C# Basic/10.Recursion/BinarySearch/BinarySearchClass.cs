using System;

namespace BinarySearch
{
    public class BinarySearchClass
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7 };

            const int number = 7;

            Console.WriteLine($"Рекурсивный бинарный поиск. Число {number} находится в массиве по индексу: " +
                              BinarySearchRecursive(array, 0, array.Length - 1, number));
            Console.WriteLine($"Обычный бинарный поиск. Число {number} находится в массиве по индексу: " +
                              BinarySearch(array, number));

            Console.Read();
        }

        public static int BinarySearch(int[] array, int value)
        {
            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }

                if (array[middle] < value)
                {
                    leftIndex = middle + 1;
                }
                else
                {
                    rightIndex = middle - 1;
                }
            }

            return -1;
        }

        public static int BinarySearchRecursive(int[] array, int leftIndex, int rightIndex, int value)
        {
            if (array == null)
            {
                return -1;
            }

            if (array.Length == 0)
            {
                return -1;
            }

            int middle = (leftIndex + rightIndex) / 2;

            if (array[middle] == value)
            {
                return middle;
            }

            int newLeftIndex = leftIndex;
            int newRightIndex = rightIndex;

            if (array[middle] < value)
            {
                newLeftIndex = middle + 1;
            }
            else
            {
                newRightIndex = middle - 1;
            }

            return BinarySearchRecursive(array, newLeftIndex, newRightIndex, value);
        }
    }
}