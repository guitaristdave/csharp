//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());

void PrintTwoDimArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
int[,] array = new int[row, column];


for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

if (row != column) Console.WriteLine("Это невозможно");
else
{
    int[,] newArray = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    Console.WriteLine("Массив: ");
    PrintTwoDimArray(array);
    Console.WriteLine("Новый массив: ");
    PrintTwoDimArray(newArray);
}

