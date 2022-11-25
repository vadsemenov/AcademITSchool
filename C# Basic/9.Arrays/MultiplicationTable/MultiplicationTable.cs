using System;

namespace MultiplicationTable
{
    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int[,] array = GetMultiplicationTable(5, 5);

            PrintMultiplicationTable(array);

            Console.Read();
        }

        private static void PrintMultiplicationTable(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("  " + array[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static int[,] GetMultiplicationTable(int tableLength1, int tableLength2)
        {
            int[,] multiplicationTableArray = new int[tableLength1, tableLength2];

            for (int i = 0; i < multiplicationTableArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationTableArray.GetLength(1); j++)
                {
                    multiplicationTableArray[i, j] = (i + 1) * (j + 1);
                }
            }

            return multiplicationTableArray;
        }
    }
}