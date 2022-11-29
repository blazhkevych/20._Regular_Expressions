using System.Text.RegularExpressions;

namespace task_1;

/// <summary>
///     1. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода
///     фамилии и инициалов пользователя в следующем виде: Иванов И.И. либо Иванов ИИ
///     Иванов И.И. Иванов ИИ   Ivanov II Ivanov I.I.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите фамилию и инициалы: ");
            var input = Console.ReadLine();
            // Проверка на пустую строку.
            if (input == string.Empty)
            {
                Console.WriteLine("Вы ввели пустую строку!");
                continue;
            }

            // Проверка на корректность ввода.
            if (
                Regex.IsMatch(input, @"^[А-Я][а-я]+ [А-Я]\.?[А-Я]\.$") ||
                Regex.IsMatch(input, @"^[А-Я][а-я]+ [А-Я][А-Я]$") ||
                Regex.IsMatch(input, @"^[A-Z][a-z]+ [A-Z]\.?[A-Z]\.$") ||
                Regex.IsMatch(input, @"^[A-Z][a-z]+ [A-Z][A-Z]$")
            )
                Console.WriteLine("Введенные данные корректны");
            else
                Console.WriteLine("Введенные данные некорректны");
        }
    }
}