using System;
using System.IO;

namespace OccurrencesNumber
{
    public class OccurrencesNumber
    {
        private const string SourceFilePath = @"..\..\1.txt";
        private const string TextSearchString = "LINE";

        static void Main(string[] args)
        {
            int stringOccurrencesNumber = 0;

            using (StreamReader reader = new StreamReader(SourceFilePath))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    while (true)
                    {
                        var tempIndex = currentLine.IndexOf(TextSearchString, StringComparison.OrdinalIgnoreCase);

                        if (tempIndex == -1)
                        {
                            break;
                        }

                        stringOccurrencesNumber++;

                        currentLine = currentLine.Substring(tempIndex + TextSearchString.Length);
                    }
                }
            }

            Console.WriteLine("Количество вхождений строки: " + stringOccurrencesNumber);

            Console.Read();
        }
    }
}