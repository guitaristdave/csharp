// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using funcs;

Console.Clear();
func.Color("green");
Console.Write("Введите высоту матрицы: ");
int width = func.Number();
func.Color("green");
Console.Write("Введите ширину матрицы: ");
int height = func.Number();
func.Color("green");
Console.Write("Введите глубину матрицы: ");
int depth = func.Number();

while(width * height * depth > 89)
{
    func.Color("red");
    Console.WriteLine("Нужно, чтобы произведение сторон было меньше 100. Попрбуйте снова. ");
    func.Color("green");
    Console.Write("Введите высоту матрицы: ");
    width = func.Number();
    func.Color("green");
    Console.Write("Введите ширину матрицы: ");
    height = func.Number();
    func.Color("green");
    Console.Write("Введите глубину матрицы: ");
    depth = func.Number();
}
int[,,] array3d = func.Create3dArray(width, height, depth);

func.Color("magenta");
for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            Console.Write($"{array3d[i, j, k]}({i}, {j}, {k})  ");
        }
        Console.WriteLine();
    }
}


Console.ResetColor();

