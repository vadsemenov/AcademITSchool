using System;

namespace Deposit
{
    public class Deposit
    {
        private const int MonthsInYearAmount = 12;
        private const int OneHundredPercent = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета вклада.");

            double deposit = GetDoubleNumberFromConsole("Введите сумму вклада:");
            double ratePerAnnum = GetDoubleNumberFromConsole("Введите ставку % годовых:");
            int depositTerm = GetIntNumberFromConsole("Введите срок вклада в месяцах:");

            double monthDepositProfit = (deposit * ratePerAnnum / OneHundredPercent) / MonthsInYearAmount;

            double simpleDepositWithInterest = deposit + monthDepositProfit * depositTerm;

            double depositWithCapitalization = deposit;

            double monthlyGrowthRate = (ratePerAnnum / OneHundredPercent) / MonthsInYearAmount;

            for (int i = 0; i < depositTerm; i++)
            {
                depositWithCapitalization += depositWithCapitalization * monthlyGrowthRate;
            }

            double simpleDepositProfit = simpleDepositWithInterest - deposit;
            double depositWithCapitalizationProfit = depositWithCapitalization - deposit;

            Console.WriteLine($"Сумма простого банковского вклада с процентами: {simpleDepositWithInterest:F2}");
            Console.WriteLine($"Прибыль по простому вкладу: {simpleDepositProfit:F2}");

            Console.WriteLine();

            Console.WriteLine($"Сумма банковского вклада с капитализацией: {depositWithCapitalization:F2}");
            Console.WriteLine($"Прибыль по вкладу с капитализацией: {depositWithCapitalizationProfit:F2}");

            Console.Read();
        }

        private static double GetDoubleNumberFromConsole(string question)
        {
            Console.WriteLine(question);

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    if (result >= 0)
                    {
                        return result;
                    }

                    Console.WriteLine("Введите значение больше или равное 0!");
                }
            }
        }

        private static int GetIntNumberFromConsole(string question)
        {
            Console.WriteLine(question);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result >= 0)
                    {
                        return result;
                    }

                    Console.WriteLine("Введите значение больше или равное 0!");
                }
            }
        }
    }
}