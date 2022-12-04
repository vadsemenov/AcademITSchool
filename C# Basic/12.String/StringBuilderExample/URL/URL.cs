using System;

namespace URL
{
    public class URL
    {
        static void Main(string[] args)
        {
            string url = @"http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";

            string someServerName = url.Split(new string[] {@"://"}, StringSplitOptions.RemoveEmptyEntries)[1];

            int index = someServerName.IndexOf('/');

            if (index != -1)
            {
                someServerName = someServerName.Substring(0, index);
            }

            Console.WriteLine("Имя сервера: " + someServerName);

            Console.Read();
        }
    }
}