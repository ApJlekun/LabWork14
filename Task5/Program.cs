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
        string password = string.Empty;
        bool isCorrectPassword = false;
        string regexPattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%_?^&*()\-+])[\da-zA-Z!@#$%_?^&*()\-+]{6,}$";

        while (!isCorrectPassword)
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            isCorrectPassword = Regex.IsMatch(password, regexPattern);

            if (!isCorrectPassword)
            {
                Console.WriteLine("Пароль не соответствует требованиям. Повторите ввод.");
            }
        }

        Console.WriteLine("Пароль соответствует требованиям.");
    }
}
