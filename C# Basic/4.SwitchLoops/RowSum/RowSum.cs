using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowSum
{
    public class RowSum
    {
        public static void Main(string[] args)
        {
            int numbersCount = GetNumberFromConsole("Введите количество чисел числового ряда:");

            int i = 1;
            int sum = 0;

            while (i <= numbersCount)
            {
                if (i % 2 == 0)
                {
                    sum -= i * i;
                }
                else
                {
                    sum += i * i;
                }

                i++;
            }

            Console.WriteLine("Сумма равна: " + sum);

            Console.Read();
        }

        private static int GetNumberFromConsole(string question)
        {
            int result;

            do
            {
                Console.WriteLine(question);
            } while (!int.TryParse(Console.ReadLine(), out result));

            return result;
        }
    }
}