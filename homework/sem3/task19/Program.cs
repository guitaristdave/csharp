// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool pal (string? number)
{
    bool result = int.TryParse(number, out int num);
    result = num > 9999 ? true : false;
    return result;
}

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

while (!pal(number) || number.Length != 5)
{
    Console.Write("Ошибка. Нужно ввести пятизначное число. Попробуйте снова: ");
    number = Console.ReadLine();
}

string reverseNumber = "";

for (int i = number.Length - 1; i >= 0; i-- )
{
    reverseNumber += number[i]; 
}

Console.WriteLine(number == reverseNumber ? $"Да, {number} - палиндром" : $"Нет, {number} - не палиндром");