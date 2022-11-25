using System;

namespace MultiplicationTable
{
    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int endNumber = 15;

            Console.Write($"     |");

            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write($"{i,5}|");
            }

            Console.Write(Environment.NewLine);

            DrawHorizontalLine(endNumber);

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i,5}|");

                for (int j = startNumber; j <= endNumber; j++)
                {
                    Console.Write($"{i * j,5}|");
                }

                Console.WriteLine();

                DrawHorizontalLine(endNumber);
            }

            Console.Read();
        }

        private static void DrawHorizontalLine(int endNumber)
        {
            for (int i = 0; i <= endNumber; i++)
            {
                Console.Write("______");
            }

            Console.Write(Environment.NewLine);
        }
    }
}