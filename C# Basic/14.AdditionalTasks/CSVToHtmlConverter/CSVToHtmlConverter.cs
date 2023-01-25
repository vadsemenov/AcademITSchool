using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CSVToHtmlConverter
{
    public class CsvToHtmlConverter
    {
        private readonly string _htmlContent;

        public CsvToHtmlConverter(string path)
        {
            try
            {
                string csvText = File.ReadAllText(path);

                string htmlTable = ParseCsvText(csvText);

                _htmlContent = CreateHtmlDocument(htmlTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private string ParseCsvText(string csvText)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.Append("<Table>");
            stringBuilder.Append(Environment.NewLine);

            csvText = Regex.Replace(csvText, "[&]", "&amp;");
            csvText = Regex.Replace(csvText, "[<]", "&lt;");
            csvText = Regex.Replace(csvText, "[>]", "&gt;");

            stringBuilder.Append("</Table>");

            return stringBuilder.ToString();
        }

        private string CreateHtmlDocument(string htmlTable)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("<Html>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("<Head><Title>Таблица</Title></Head>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("<Body>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(htmlTable);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("</Body>");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("</Html>");

            return stringBuilder.ToString();
        }

        public void SaveHtmlToFile(string path)
        {
            try
            {
                File.WriteAllText(path, _htmlContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}