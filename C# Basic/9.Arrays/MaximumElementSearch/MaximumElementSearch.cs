using System;

namespace MaximumElementSearch
{
    internal class MaximumElementSearch
    {
        static void Main(string[] args)
        {
            int[] array = {2, 5, 6, 7, 8, 10};

            Console.WriteLine("Максимальный элемент в массиве - " + GetMaxElement(array));

            Console.Read();
        }

        public static int GetMaxElement(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Массив не инициализирован!");
            }

            if (array.Length == 0)
            {
                throw new ArgumentNullException("Массив не содержит элементов!");
            }

            int maxElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            return maxElement;
        }
    }
}