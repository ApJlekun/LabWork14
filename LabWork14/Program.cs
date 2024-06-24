using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер телефона: ");
            string input = Console.ReadLine();

            string regexPattern = @"^(\+7|8)\((9\d{2})\)\d{3}-\d{2}-\d{2}$";

            if (Regex.IsMatch(input, regexPattern))
            {
                Console.WriteLine("Номер телефона корректен");
            }
            else
            {
                Console.WriteLine("Номер телефона некорректен");
            }
        }
    }
}