// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using funcs;

Console.Clear();
func.Color("green");
Console.Write("Введите число строк массива: ");
int row = func.Number();



func.Color("green");
Console.Write("Введите число столбцов массива: ");
int column = func.Number();


int[,] array = func.GetRandomTwoDimArray(row, column);
int minRow = int.MaxValue;
int minRowIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
       rowSum += array[i, j];
    }
    if (rowSum < minRow)
    {
        minRowIndex = i;
        minRow = rowSum;
    }
}

func.PrintTwoDimArray(array);

Console.WriteLine($"Строка с минимальной суммой элементов: {minRowIndex + 1}");