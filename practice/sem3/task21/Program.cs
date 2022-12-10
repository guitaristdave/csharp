// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double distance (int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
    return result;
}

Console.Write("Введите координату Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату By: ");
int by = Convert.ToInt32(Console.ReadLine());

double dist = distance(ax, ay, bx, by);

Console.WriteLine($"Расстояние между точками A ({ax}, {ay}) и B ({bx}, {by}) = {dist}");



