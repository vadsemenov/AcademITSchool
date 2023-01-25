using System;

namespace QuickSort
{
    public class QuickSort
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 1, 3, 2, 4, 5, 6 };

            SortArray(array, 0, array.Length - 1);

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));

            Console.Read();
        }

        private static void SortArray(int[] array, int leftIndex, int rightIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), $"Массив {nameof(array)} не инициализирован!");
            }

            if (leftIndex >= rightIndex)
            {
                return;
            }

            int i = leftIndex;
            int j = rightIndex;
            int pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                SortArray(array, leftIndex, j);
            }

            if (i < rightIndex)
            {
                SortArray(array, i, rightIndex);
            }
        }
    }
}
