using System;

namespace SelectionSort
{
    public class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = {10, 1, 3, 2, 4, 5, 6};

            SortArray(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));

            Console.Read();
        }

        private static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tempMinIndex = GetMinValueIndex(array, i);

                if (array[i] > array[tempMinIndex])
                {
                    int temp = array[tempMinIndex];
                    array[tempMinIndex] = array[i];
                    array[i] = temp;
                }
            }
        }

        private static int GetMinValueIndex(int[] array, int startIndex = 0)
        {
            int minIndex = startIndex;

            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[minIndex] > array[i])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}