// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using funcs;
Console.Clear();

func.Color("green");
Console.Write("Введите количество строк в массиве: ");
func.Color("yellow");
string Row = Console.ReadLine();
while(!func.isNatural(Row))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попробуйте снова: ");
    func.Color("yellow");
    Row = Console.ReadLine();
}

func.Color("green");
Console.Write("Введите количество столбцов в массиве: ");
func.Color("yellow");
string Column = Console.ReadLine();
while(!func.isNatural(Column))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попробуйте снова: ");
    func.Color("yellow");
    Column = Console.ReadLine();
}

int row = int.Parse(Row);
int column = int.Parse(Column);

int[,] array = func.GetRandomTwoDimArray(row, column);
func.Color("magenta");
Console.WriteLine("Ваш массив:");
func.PrintTwoDimArray(array);
Console.WriteLine();
func.Color("yellow");
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < array.GetLength(1); i++)
{
    double[] col = new double[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        col[j] = array[j, i];
        
    }
    Console.Write($"{func.Average(col)}, ");
}



