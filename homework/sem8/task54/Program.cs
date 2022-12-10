// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using funcs;
Console.Clear();

func.Color("green");
Console.Write("Введите количество строк в массиве: ");
int row = func.Number();

func.Color("green");
Console.Write("Введите количество столбцов в массиве: ");
int column = func.Number();


int[,] array = func.GetRandomTwoDimArray(row, column, 1, 10);

func.Color("magenta");
Console.WriteLine($"Ваш массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Отсортированный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    int[] sortArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sortArray[j] = array[i, j];
    }
    Array.Sort(sortArray);
    Console.WriteLine($"{String.Join(" ", sortArray)}");
}