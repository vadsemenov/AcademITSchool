using System;

namespace TemperatureConverter
{
    public class TemperatureConverter
    {
        static void Main(string[] args)
        {
            double celsiusDegrees = GetNumberFromConsole("Введите температуру в градусах Цельсия:");

            Console.WriteLine("Температура в градусах Кельвина - " + ConvertCelsiusToKelvin(celsiusDegrees));
            Console.WriteLine("Температура в градусах Фаренгейта - " + ConvertCelsiusToFahrenheit(celsiusDegrees));

            Console.ReadLine();
        }

        private static double GetNumberFromConsole(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }

                Console.WriteLine("Введено не верное значение. Повторите ввод.");
            }
        }

        private static double ConvertCelsiusToKelvin(double celsiusDegrees)
        {
            return celsiusDegrees + 273.15;
        }

        private static double ConvertCelsiusToFahrenheit(double celsiusDegrees)
        {
            return (celsiusDegrees * (9.0 / 5)) + 32;
        }
    }
}