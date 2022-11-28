using System.Text.RegularExpressions;

namespace task_1
{
    /// <summary>
    /// 1. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода
    /// фамилии и инициалов пользователя в следующем виде: Иванов И.И. либо Иванов ИИ
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию и инициалы: ");
            string input = Console.ReadLine();
            Regex regexEngShort1 = new Regex(@"^[A-Z]{1}[a-z]{5} [A-Z]{2}$");
            Regex regexEngLong2 = new Regex(@"^[A-Z]{1}[a-z]{5} [A-Z]{1}[.]{1}[A-Z]{1}[.]{1}$");
            Regex regexCyrillicShort1 = new Regex(@"^[А-Я]{1}[а-я]{5} [А-Я]{2}$");
            Regex regexCyrillicLong2 = new Regex(@"^[А-Я]{1}[а-я]{5} [Я-Я]{1}[.]{1}[А-Я]{1}[.]{1}$");
            if (
                regexEngShort1.IsMatch(input) || regexEngLong2.IsMatch(input) ||
                regexCyrillicShort1.IsMatch(input) || regexCyrillicLong2.IsMatch(input)
                )
            {
                Console.WriteLine("Введенные данные корректны");
            }
            else
            {
                Console.WriteLine("Введенные данные некорректны");
            }
        }
    }
}