using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше предложение, а я уберу из него лишние пробелы: ");
            string input = Console.ReadLine();
            string regexPattern = @"\s{2,}"; 
            string replacement = " "; 

            string result = Regex.Replace(input, regexPattern, replacement);

            Console.WriteLine("Строка после замены: " + result);
        }
    }
}

