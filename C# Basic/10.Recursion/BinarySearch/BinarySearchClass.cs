using System;

namespace BinarySearch
{
    //Такое имя класса потому что он должен называться по смыслу BinarySearch, но есть метод с таким же именем
    //Метод я переименовал по предыдущему замечанию. 
    public class BinarySearchClass
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 5, 6, 7};

            const int numberSeven = 7;

            Console.WriteLine($"Рекурсивный бинарный поиск. Число {numberSeven} находится в массиве по индексу: " +
                              BinarySearchRecursive(array, 0, array.Length - 1, numberSeven));
            Console.WriteLine($"Обычный бинарный поиск. Число {numberSeven} находится в массиве по индексу: " +
                              BinarySearch(array, numberSeven));

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
                else if (value < array[middle])
                {
                    rightIndex = middle - 1;
                }
            }

            // Исключение потому что нужнен return, return нужен потому что я поменял условие цикла (было true),
            // а если вернуть -1, то будет вопрос что -1 может быть в массиве,
            // если вернуть int.MinValue или int.MaxValue то они тоже могут быть в массиве.
            throw new Exception("Элемент не найден");
        }

        public static int BinarySearchRecursive(int[] array, int leftIndex, int rightIndex, int value)
        {
            int middle = (leftIndex + rightIndex) / 2;
            int newLeftIndex = leftIndex;
            int newRightIndex = rightIndex;

            if (array[middle] == value)
            {
                return middle;
            }

            if (array[middle] < value)
            {
                newLeftIndex = middle + 1;
            }
            else if (value < array[middle])
            {
                newRightIndex = middle - 1;
            }

            return BinarySearchRecursive(array, newLeftIndex, newRightIndex, value);
        }
    }
}