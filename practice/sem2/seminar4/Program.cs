// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого");
}
