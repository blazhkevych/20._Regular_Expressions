using System.Text.RegularExpressions;

namespace task_2;

/// <summary>
///     2. Написать приложение, проверяющее с помощью регулярного выражения корректность ввода адреса электронной почты.
///     Адрес электронной почты должен иметь следующий вид: login@host, где login - последовательность из букв, цифр и
///     символа "_", начинающаяся с буквы. Длина - от 3 до 16 символов. host - строка вида mail.ru или mail.odessa.ua и
///     т.п. В
///     конце host должен содержать от 2 до 3 символов (ua, com, net, ru и т.д.)
///     iva123no_v@mail.odessa.ua
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            // Введите адрес электронной почты.
            Console.WriteLine("Введите адрес электронной почты: ");
            var input = Console.ReadLine();
            // Проверка на пустую строку.
            if (input == string.Empty)
            {
                Console.WriteLine("Вы ввели пустую строку!");
                continue;
            }

            if (Regex.IsMatch(input,
                    "^((([A-Za-z]{1}[0-9A-Za-z_]{2,15})|([А-Яа-я]{1}[0-9А-Яа-я_]{2,15}))@([A-Za-z]{1,}\\.){1,2}[A-Za-z]{2,3})$"))
            {
                Console.WriteLine("Адрес электронной почты " + input + " введен верно.");
                continue;
            }

            Console.WriteLine("Введенный адрес электронной почты " + input + " некорректен.");
        }
    }
}