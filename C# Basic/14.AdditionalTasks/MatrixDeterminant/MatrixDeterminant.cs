using System;

namespace MatrixDeterminant
{
    public class MatrixDeterminant
    {
        public static void Main(string[] args)
        {
            double[,] matrix = new double[5, 5];

            matrix[0, 0] = 4;
            matrix[0, 1] = 1;
            matrix[0, 2] = 1;
            matrix[0, 3] = 2;
            matrix[0, 4] = 1;

            matrix[1, 0] = 1;
            matrix[1, 1] = 2;
            matrix[1, 2] = -1;
            matrix[1, 3] = 1;
            matrix[1, 4] = 1;

            matrix[2, 0] = 3;
            matrix[2, 1] = 1;
            matrix[2, 2] = 1;
            matrix[2, 3] = 1;
            matrix[2, 4] = 1;

            matrix[3, 0] = 2;
            matrix[3, 1] = 1;
            matrix[3, 2] = 1;
            matrix[3, 3] = 4;
            matrix[3, 4] = 1;

            matrix[4, 0] = 2;
            matrix[4, 1] = -1;
            matrix[4, 2] = 1;
            matrix[4, 3] = 1;
            matrix[4, 4] = 5;

            double determinant = FindMatrixDeterminant(matrix);

            Console.WriteLine("Детерминант матрицы равен:" + determinant);

            Console.Read();
        }

        public static double FindMatrixDeterminant(double[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Массив не инициализирован!");
            }

            if (matrix.GetLength(0) <= 1 || matrix.GetLength(1) <= 1)
            {
                throw new ArgumentException("Размер матрицы должен быть не менее 2х2!", nameof(matrix));
            }

            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Колличество строк в матрице должно быть равно колличеству столбцов!",
                    nameof(matrix));
            }

            int matrixDimension = matrix.GetLength(0);

            double[,] tempMatrix = matrix.Clone() as double[,];

            double determinant;

            for (int i = 0; i < matrixDimension - 1; i++)
            {
                for (int j = i + 1; j < matrixDimension; j++)
                {
                    determinant = tempMatrix[j, i] / tempMatrix[i, i];

                    for (int k = i; k < matrixDimension; k++)
                    {
                        tempMatrix[j, k] -= determinant * tempMatrix[i, k];
                    }
                }
            }

            determinant = 1;

            for (int l = 0; l < matrixDimension; l++)
            {
                determinant *= tempMatrix[l, l];
            }

            return determinant;
        }
    }
}