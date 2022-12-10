// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

using funcs;
Console.Clear();

func.Color("green");
Console.Write("Введите размер квадратного массива: ");
int n = func.Number();

int[,] matrix = new int[n, n];

int keyNum = 0;
int number = 1;
int cellWidth = 0;
int lastNumber = n * n;

while(lastNumber > 0)
{
    lastNumber /= 10;
    cellWidth++;
}

int minX = 0;
int minY = -1;
int maxX = matrix.GetLength(0);
int maxY = matrix.GetLength(1);

for (int x = 0, y = 0; true; )
{
    switch (keyNum)
    {
        case 0:
            matrix[x, y++] = number++;
            if (y == maxY)
            {
                keyNum = 1;
                maxY--;
                x++;
                y--;
            }
            if (number == Math.Pow(n, 2)) keyNum = 5;
            break;
        case 1:
            matrix[x++, y] = number++;
            if (x == maxX)
            {
                keyNum = 2;
                maxX--;
                y--;
                x--;
            }
            if (number == Math.Pow(n, 2)) keyNum = 5;
            break;
        case 2:
            matrix[x, y--] = number++;
            if (y == minY)
            {
                keyNum = 3;
                minY++;
                x--;
                y++;
            }
            if (number == Math.Pow(n, 2)) keyNum = 5;
            break;
        case 3:
            matrix[x--, y] = number++;
            if (x == minX)
            {
                keyNum = 0;
                minX++;
                y++;
                x++;

            }
            if (number == Math.Pow(n, 2)) keyNum = 5;
            break;
        default:
            break;

    };
    matrix[x, y] = number;
    if (number == Math.Pow(n, 2)) break;
}

var numbers = new string[n, n];

func.Color("cyan");
Console.WriteLine($"Ваш массив размером {n} x {n}:");
func.Color("magenta");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        numbers[i, j] = matrix[i, j].ToString().PadLeft(cellWidth, '0');
        Console.Write($"{numbers[i, j]} ");
    }
    Console.WriteLine();
}

Console.ResetColor();