//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Holiday(string? number)
{
    bool result = int.TryParse(number, out int num);
    result = (num > 0 && num < 8) ? true : false;
    return result;
}

Console.Write("Введите номер дня недели (от 1 до 7): ");
string? number = Console.ReadLine();

int day = 0;

while (day == 0)
{
    while (!Holiday(number) || number.Length != 1)
    {
        Console.Write("Вы не ввели цифру от 1 до 7. Попробуйте снова: ");
        number = Console.ReadLine();
    }
    day = Int32.Parse(number);
}

string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine(day < 6 ? $"Нет, {week[day - 1]} - не выходной." : $"Да {week[day - 1]} - выходной");