using System;

namespace NextDate
{
    public class NextDate
    {
        static void Main(string[] args)
        {
            int day = GetNumberFromConsole("Введите сегодняшнюю дату:");
            int month = GetNumberFromConsole("Введите номер текущего месяца:");
            int year = GetNumberFromConsole("Введите текущий год:");

            int dayMaxValue = 31;

            if (IsLeapYear(year) && month == 2)
            {
                dayMaxValue = 29;
            }
            else if (month == 2)
            {
                dayMaxValue = 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                dayMaxValue = 30;
            }

            if (day < 1 || day > dayMaxValue || month < 1 || month > 12 || year < 0)
            {
                Console.WriteLine("Введена некорректная дата.");

                Console.Read();

                return;
            }

            int nextDateDay;
            int nextDateMonth = month;
            int nextDateYear = year;

            if (day == dayMaxValue)
            {
                nextDateDay = 1;

                if (month == 12)
                {
                    nextDateMonth = 1;
                    nextDateYear = year + 1;
                }
                else
                {
                    nextDateMonth = month + 1;
                }
            }
            else
            {
                nextDateDay = day + 1;
            }

            Console.WriteLine($"Дата следующего дня: {nextDateDay:D2}.{nextDateMonth:D2}.{nextDateYear:D4}");

            Console.Read();
        }

        private static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
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