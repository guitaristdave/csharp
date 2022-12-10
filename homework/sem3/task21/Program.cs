// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
    result = Math.Round(result, 2);
    return result;
}
Console.Write("Введите координату Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double dist = distance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между точками A({ax}, {ay}, {az}) и B({bx}, {by}, {bz}) = {dist}");
