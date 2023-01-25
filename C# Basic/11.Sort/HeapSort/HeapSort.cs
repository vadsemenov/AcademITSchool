using System;

namespace HeapSort
{
    public class HeapSort
    {
        public static void Main(string[] args)
        {
            int[] array = { 10, 1, 3, 2, 4, 5, 6 };

            SortArray(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));

            Console.Read();
        }

        private static void SortArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), $"Массив {nameof(array)} не инициализирован");
            }

            int size = array.Length;

            if (size <= 1)
            {
                return;
            }

            for (int i = size / 2 - 1; i >= 0; i--)
            {
                SiftElement(array, size, i);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                SiftElement(array, i, 0);
            }
        }

        private static void SiftElement(int[] array, int size, int index)
        {
            while (index * 2 + 1 < size)
            {
                int maxChildIndex;

                int leftChildIndex = index * 2 + 1;
                int rightChildIndex = index * 2 + 2;

                if (leftChildIndex == size - 1)
                {
                    maxChildIndex = leftChildIndex;
                }
                else if (array[leftChildIndex] > array[rightChildIndex])
                {
                    maxChildIndex = leftChildIndex;
                }
                else
                {
                    maxChildIndex = rightChildIndex;
                }

                if (array[index] >= array[maxChildIndex])
                {
                    return;
                }

                int temp = array[index];
                array[index] = array[maxChildIndex];
                array[maxChildIndex] = temp;

                index = maxChildIndex;
            }
        }
    }
}