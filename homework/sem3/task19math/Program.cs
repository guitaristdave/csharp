// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

bool isNumber = int.TryParse(number, out int num);
isNumber = num > 9999 ? true : false;

while (!isNumber || number.Length != 5)
{
    Console.Write("Ошибка. Введите пятизначное число: ");
    number = Console.ReadLine();
    isNumber = int.TryParse(number, out num);
    isNumber = num > 9999 ? true : false;
}

int first = num / 10000;
int second = num / 1000 % 10;
int forth = num / 10 % 10;
int fifth = num % 10;

if (first == fifth && second == forth)
{
    Console.WriteLine($"Да, {num} - палиндром");
}
else
{
    Console.WriteLine($"Нет, {num} - не палиндром");
}
