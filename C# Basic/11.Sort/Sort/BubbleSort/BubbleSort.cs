using System;

namespace BubbleSort
{
    public class BubbleSort
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
            for (int i = 1; i <= array.Length; i++)
            {
                bool isComparsion = false;

                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        isComparsion = true;
                    }
                }

                if (!isComparsion)
                {
                    break;
                }
            }
        }
    }
}