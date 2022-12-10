// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using funcs;
Console.Clear();

func.Color("green");
Console.Write("Введите количество строк 1 матрицы: ");
int row1 = func.Number();
func.Color("green");
Console.Write("Введите количество стобцов 1 матрицы: ");
int column1 = func.Number();
func.Color("green");
Console.Write("Введите количество строк 2 матрицы: ");
int row2 = func.Number();
func.Color("green");
Console.Write("Введите количество стобцов 2 матрицы: ");
int column2 = func.Number();

int[,] matrix1 = func.GetRandomTwoDimArray(row1, column1, 1, 10);
int[,] matrix2 = func.GetRandomTwoDimArray(row2, column2, 1, 10);

Console.WriteLine("Матрица 1:");
func.PrintTwoDimArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
func.PrintTwoDimArray(matrix2);
Console.WriteLine();

func.Color("magenta");
if (column1 != row2) Console.WriteLine("Умножение невозможно. Матрицы не согласованы.");
else
{
    int[,] result = func.MatrixMultiply(matrix1, matrix2);
    Console.WriteLine("Результат уменожения:");
    func.PrintTwoDimArray(result);
}
