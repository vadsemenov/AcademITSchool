using System;

namespace CharactersCount
{
    public class CharactersCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string userString = Console.ReadLine();

            int lettersAmount = 0;
            int digitsAmount = 0;
            int whiteSpaceCharsAmount = 0;
            int otherCharsAmount = 0;

            if (!string.IsNullOrEmpty(userString))
            {
                for (int i = 0; i < userString.Length; i++)
                {
                    char character = userString[i];

                    if (char.IsLetter(character))
                    {
                        lettersAmount++;
                    }
                    else if (char.IsDigit(character))
                    {
                        digitsAmount++;
                    }
                    else if (char.IsWhiteSpace(character))
                    {
                        whiteSpaceCharsAmount++;
                    }
                    else
                    {
                        otherCharsAmount++;
                    }
                }
            }

            Console.WriteLine("Число букв в строке: " + lettersAmount);
            Console.WriteLine("Число цифр в строке: " + digitsAmount);
            Console.WriteLine("Число пробелов в строке: " + whiteSpaceCharsAmount);
            Console.WriteLine("Число остальных символов в строке: " + otherCharsAmount);

            Console.Read();
        }
    }
}