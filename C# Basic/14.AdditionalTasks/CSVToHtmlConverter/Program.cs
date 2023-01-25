using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVToHtmlConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            CsvToHtmlConverter converter = new CsvToHtmlConverter(@"G:\1.txt");
            converter.SaveHtmlToFile(@"G:\2.html");
        }
    }
}
