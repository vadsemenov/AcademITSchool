using System.IO;

namespace FileLinesToUpperCase
{
    public class FileLinesToUpperCase
    {
        private const string SourceFilePath = @"..\..\1.txt";
        private const string DestinationFilePath = @"..\..\2.txt";

        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader(SourceFilePath);

            using StreamWriter writer = new StreamWriter(DestinationFilePath);

            string currentLine;

            while ((currentLine = reader.ReadLine()) != null)
            {
                writer.WriteLine(currentLine.ToUpper());
            }
        }
    }
}