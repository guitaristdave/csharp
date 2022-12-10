// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using funcs;

int sumDigits(int num)
{
    int result = 0;
    while (num > 10)
    {
        result += num % 10;
        num = num / 10;
    }
    result += num;
    return result;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
while (!func.isNumber(number))
{
    Console.Write("Вы ввели не число. Попробуйте снова: ");
    number = Console.ReadLine();
}

int num = Math.Abs(int.Parse(number));

int result = sumDigits(num);
Console.WriteLine($"Сумма цифр числа {num} = {result}");