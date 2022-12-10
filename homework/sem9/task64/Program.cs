//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
using funcs;
Console.Clear();

func.Color("yellow");
Console.WriteLine("Программа выведет все натуральные числа от n до 1.");
Console.WriteLine();

func.Color("green");
Console.Write("Введите число N: ");
int n = func.Number();

func.Color("magenta");

void PrintNums(int number)
{
    Console.Write($"{number} ");
    if (number == 1) return;
    PrintNums(number - 1);
}


Console.Write($"Числа от {n} до 1: ");
PrintNums(n);

Console.ResetColor();