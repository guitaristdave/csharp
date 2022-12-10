// программа принимает число N и сообщает количество цифр в числе

using learn;

int numCount(string num)
{
    int result = num.Length;
    return result;
}

Console.Write("Введите число: ");
string? num = Console.ReadLine();

while(!func.isNumber(num))
{
    Console.Write("Вы ввели не число. Попробуйте снова: ");
    num = Console.ReadLine();
}

Console.WriteLine($"Количество цифр в числе {num}: {numCount(num)}");