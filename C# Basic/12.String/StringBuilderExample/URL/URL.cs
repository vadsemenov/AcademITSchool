using System;

namespace Url
{
    public class Url
    {
        static void Main(string[] args)
        {
            string url = "http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";

            string serverName = GetServerName(url);

            Console.WriteLine("Имя сервера: " + serverName);

            Console.Read();
        }

        private static string GetServerName(string url)
        {
            int startIndex = url.IndexOf("://", StringComparison.OrdinalIgnoreCase);

            if (startIndex == -1)
            {
                throw new ArgumentException("Не валидная строка. Не удалось распарсить строку.", nameof(url));
            }

            startIndex += 3;

            int endIndex = url.IndexOf('/', startIndex);

            return endIndex == -1 ? url.Substring(startIndex) : url.Substring(startIndex, endIndex - startIndex);
        }
    }
}