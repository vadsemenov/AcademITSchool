using System;

namespace BinarySearch
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 5, 6, 7};

            Console.WriteLine("Рекурсивный бинарный поиск. Число 7 находится в массиве по индексу: " + BinarySearchRecursive(array, 0, array.Length - 1, 7));
            Console.WriteLine("Обычный бинарный поиск. Число 7 находится в массиве по индексу: " + BinarySearchSimple(array, 0, array.Length - 1, 7));

            Console.Read();
        }

        public static int BinarySearchSimple(int[] array, int leftIndex, int rightIndex, int value)
        {
            while (true)
            {
                if (leftIndex > rightIndex)
                {
                    return -1;
                }

                int middle = (leftIndex + rightIndex) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }

                if (array[middle] < value)
                {
                    leftIndex = middle + 1;
                }

                if (value < array[middle])
                {
                    rightIndex = middle - 1;
                }
            }
        }

        public static int BinarySearchRecursive(int[] array, int leftIndex, int rightIndex, int value)
        {
            if (leftIndex > rightIndex)
            {
                return -1;
            }

            int middle = (leftIndex + rightIndex) / 2;

            if (array[middle] == value)
            {
                return middle;
            }

            if (array[middle] < value)
            {
                leftIndex = middle + 1;
            }

            if (value < array[middle])
            {
                rightIndex = middle - 1;
            }

            return BinarySearchRecursive(array, leftIndex, rightIndex, value);
        }
    }
}