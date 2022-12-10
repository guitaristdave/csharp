// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using funcs;
Console.Clear();

void LinesDot(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        func.Color("magenta");
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
        double y = Math.Round((k1 * x + b1), 2);
        func.Color("magenta");
        Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");
    }
}

string[] coordNames = {"k1", "b1", "k2", "b2"};
double[] coords = new double[4];
string num = "";

for (int i = 0; i < coordNames.Length; i++)
{
    func.Color("green");
    Console.Write($"Введите {coordNames[i]}: ");
    num = Console.ReadLine();
    while(!func.isDouble(num))
    {
        func.Color("red");
        Console.Write("Нужно ввести число. Попробуйте снова: ");
        num = Console.ReadLine();
    }
    coords[i] = int.Parse(num);
}

LinesDot(coords[0], coords[1], coords[2], coords[3]);