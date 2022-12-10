// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using funcs;

Console.Write("Какое число возвести в степень: ");
string? A = Console.ReadLine();
while (!func.isNumber(A))
{
    Console.Write("Нужно ввести число. Попробуйте снова: ");
    A = Console.ReadLine();
}

Console.Write("В какую степень возвести: ");
string? B = Console.ReadLine();
while (!func.isNatural(B))
{
    Console.Write("Нужно ввести натуральное число. Попробуйте снова: ");
    B = Console.ReadLine();
}

int a = int.Parse(A);
int b = int.Parse(B);

int result = func.Pow(a, b);

Console.WriteLine($"{a}^{b} = {result}");

