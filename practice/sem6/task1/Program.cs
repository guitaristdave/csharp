// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Clear();
int a, b, c;
Console.WriteLine("'");
Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}