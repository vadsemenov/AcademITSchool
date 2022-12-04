using System;

namespace MultiplicationTable
{
    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTableArray = GetMultiplicationTable(2, 5);

            PrintMultiplicationTable(multiplicationTableArray);

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

        public static int[,] GetMultiplicationTable(int tableRowsAmount, int tableColumnsAmount)
        {
            int[,] multiplicationTableArray = new int[tableRowsAmount, tableColumnsAmount];

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