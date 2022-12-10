// программа выводит 3 цифру числа или сообщает, что 3 цифры нет

bool Third (string? number)
{
    bool result = int.TryParse(number, out int num);
    return result;
}

Console.Write("Введите число: ");
string? number = Console.ReadLine();

while (!Third(number))
{
    Console.Write("Вы ввели не число. Попробуйте снова: ");
    number = Console.ReadLine();
}

int num = Int32.Parse(number);

Console.WriteLine(num > 99 ? $"Третья цифра числа: {number[2]}" : "Третьей цифры нет");