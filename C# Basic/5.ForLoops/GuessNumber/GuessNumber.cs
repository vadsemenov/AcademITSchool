using System;

namespace GuessNumber
{
    public class GuessNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Угадай число от 1 до 100!");

            Random random = new Random();

            int guessNumber = random.Next(1, 101);

            int attemptsAmount = 0;

            while (true)
            {
                int userNumber = GetNumberFromConsole("Введите число от 1 до 100:");

                attemptsAmount++;

                if (userNumber == guessNumber)
                {
                    Console.WriteLine($"Вы угадали число! Количество попыток {attemptsAmount}");
                    break;
                }

                if (userNumber < guessNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число Меньше.");
                }
            }

            Console.Read();
        }

        private static int GetNumberFromConsole(string question)
        {
            Console.WriteLine(question);

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result >= 1 && result <= 100)
                    {
                        return result;
                    }

                    Console.WriteLine("Введите число от 1 до 100.");
                }

                Console.WriteLine("Введено не верное значение. Введите еще раз.");
            }
        }
    }
}