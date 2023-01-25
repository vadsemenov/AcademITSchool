using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] array = {10, 1, 3, 2, 4, 6, 5};

            SortArray(array);

            Console.WriteLine("Отсортированный массив: " + string.Join(" ", array));

            Console.Read();
        }

        private static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];

                for (int j = i - 1;; j--)
                {
                    if (j < 0 || array[j] <= temp)
                    {
                        array[j + 1] = temp;
                        break;
                    }

                    array[j + 1] = array[j];
                }
            }
        }
    }
}