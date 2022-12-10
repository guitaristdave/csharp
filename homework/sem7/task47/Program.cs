//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using funcs;


Console.Clear();
func.Color("green");
Console.Write("Введите число строк массива: ");
func.Color("yellow");
string Row = Console.ReadLine();

while(!func.isNatural(Row))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попрбоуйте снова: ");
    func.Color("yellow");
    Row = Console.ReadLine();
}

func.Color("green");
Console.Write("Введите число столбцов массива: ");
func.Color("yellow");
string Column = Console.ReadLine();

while(!func.isNatural(Column))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попрбоуйте снова: ");
    func.Color("yellow");
    Column = Console.ReadLine();
}

int row = int.Parse(Row);
int column = int.Parse(Column);

double[,] array = func.GetRandomDoubleTwoDimArray(row, column);
func.Color("yellow");
Console.WriteLine($"Двумерный массив размером {row}x{column}, наполненный случайными вещественными числами:");
func.Color("magenta");
func.PrintDoubleTwoDimArray(array);
