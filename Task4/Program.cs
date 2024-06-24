using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваш E-mail: ");
        string email = Console.ReadLine();
        string regexPattern = @"^[a-zA-Z0-9-_]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";

        bool isValidEmail = Regex.IsMatch(email, regexPattern, RegexOptions.IgnoreCase);

        Console.WriteLine("E-mail адрес: " + email);
        Console.WriteLine("Корректный ли адрес: " + isValidEmail);
    }
}
