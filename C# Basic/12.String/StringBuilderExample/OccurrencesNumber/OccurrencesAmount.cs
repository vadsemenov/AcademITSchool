using System;
using System.IO;

namespace OccurrencesAmount
{
    public class OccurrencesAmount
    {
        private const string SourceFilePath = @"..\..\1.txt";
        private const string TextSearchString = "LINE";

        static void Main(string[] args)
        {
            int stringOccurrencesAmount = 0;

            using (StreamReader reader = new StreamReader(SourceFilePath))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    int occurrenceIndex = 0;

                    while (true)
                    {
                        occurrenceIndex = currentLine.IndexOf(TextSearchString, occurrenceIndex,
                            StringComparison.OrdinalIgnoreCase);

                        if (occurrenceIndex == -1)
                        {
                            break;
                        }

                        stringOccurrencesAmount++;

                        occurrenceIndex += TextSearchString.Length;
                    }
                }
            }

            Console.WriteLine("Количество вхождений строки: " + stringOccurrencesAmount);

            Console.Read();
        }
    }
}