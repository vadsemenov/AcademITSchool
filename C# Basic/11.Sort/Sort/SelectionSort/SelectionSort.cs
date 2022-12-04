﻿using System;

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
            int minIndex, temp;

            for (int i = 0; i < array.Length; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}