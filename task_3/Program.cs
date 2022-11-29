using System.Text.RegularExpressions;

namespace task_3
{
    /// <summary>
    /// 3. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода даты в формате Число-Месяц-Год (например, 01-04-2015). 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
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
                // Проверка на корректность ввода.
                if (Regex.IsMatch(input, @"^\d{2}-\d{2}-\d{4}$"))
                    Console.WriteLine("Введенные данные корректны");
                else
                    Console.WriteLine("Введенные данные некорректны");
            }
        }
    }
}