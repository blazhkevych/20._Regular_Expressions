using System.Text.RegularExpressions;

namespace task_3;

/// <summary>
///     3. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода даты в формате
///     Число-Месяц-Год (например, 01-04-2015).
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            // Ввод даты в формате Число-Месяц-Год (например, 01-04-2015).
            Console.WriteLine("Введите дату в формате Число-Месяц-Год (например, 01-04-2015): ");
            var input = Console.ReadLine();
            // Проверка на пустую строку.
            if (input == string.Empty)
            {
                Console.WriteLine("Вы ввели пустую строку!");
                continue;
            }

            // Проверка на корректность ввода и допустимые значения для дня, месяца и года учитывая високосные года.
            if (
                Regex.IsMatch(input, @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[012])-(19|20)\d\d$") &&
                int.Parse(input.Substring(0, 2)) <= DateTime.DaysInMonth(int.Parse(input.Substring(6, 4)), int.Parse(input.Substring(3, 2)))
            )
                Console.WriteLine("Введенные данные корректны");
            else
                Console.WriteLine("Введенные данные некорректны");
        }
    }
}