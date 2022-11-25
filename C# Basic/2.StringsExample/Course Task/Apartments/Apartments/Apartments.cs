using System;

namespace Apartments
{
    // Задача на курс «Квартиры»
    public class Apartments
    {
        static void Main(string[] args)
        {
            const int floorApartmentsAmount = 4;

            int porchesAmount = GetNumberFromConsole("Введите количество подъездов:");
            int floorsAmount = GetNumberFromConsole("Введите количество этажей:");
            int apartmentNumber = GetNumberFromConsole("Введите номер квартиры:");

            int allApartmentsAmount = porchesAmount * floorsAmount * floorApartmentsAmount;

            if (apartmentNumber > allApartmentsAmount)
            {
                Console.WriteLine("Квартиры с таким номером нет в доме!");
                Console.ReadLine();
                return;
            }

            int apartmentPorch = (apartmentNumber - 1) / (floorsAmount * floorApartmentsAmount) + 1;

            int apartmentFloor = ((apartmentNumber - 1) - (apartmentPorch - 1) * floorsAmount * floorApartmentsAmount) /
                floorApartmentsAmount + 1;

            Console.WriteLine($"Квартира находится в {apartmentPorch} подъезде");
            Console.WriteLine($"Квартира находится на {apartmentFloor} этаже");

            switch (apartmentNumber % floorApartmentsAmount)
            {
                case 1:
                    Console.WriteLine("Ближняя слева квартира");
                    break;
                case 2:
                    Console.WriteLine("Дальняя слева квартира");
                    break;
                case 3:
                    Console.WriteLine("Дальняя справа квартира");
                    break;
                case 0:
                    Console.WriteLine("Ближняя справа квартира");
                    break;
            }

            Console.ReadLine();
        }

        private static int GetNumberFromConsole(string question)
        {
            int result;

            do
            {
                Console.WriteLine(question);
            } while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);

            return result;
        }
    }
}