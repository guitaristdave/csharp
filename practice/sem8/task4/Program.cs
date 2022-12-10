// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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
int[,] newArray = new int[row-1, column-1];


for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

int x = 0;
int y = 0;
int min = 9;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((array[i, j]) < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}

for (int i = 0, k = 0, l = 0; i < array.GetLength(0); i++)
{
    if (i == x) continue;
    k++;
    l++;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == y) continue;
        newArray[k, l] = array[i, j];
    }
    
}

PrintTwoDimArray(array);
Console.WriteLine();
PrintTwoDimArray(newArray);