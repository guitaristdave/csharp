//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

func.Color("yellow");
Console.WriteLine("Ваш массив");
func.Color("magenta");
func.PrintTwoDimArray(array);

func.Color("green");
Console.Write("Введите позицию элемента в формате XY (X - строка, Y - столбец): ");
func.Color("yellow");
string position = Console.ReadLine();
while(!func.isNum(position, 10))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 10. Попробуйте снова: ");
    func.Color("yellow");
    position = Console.ReadLine();
}

int elementPosition = int.Parse(position);
bool inArray = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (elementPosition == ((i + 1) * 10 + j + 1))
        {
            inArray = true;
        }
    }
}

func.Color("magenta");
if(inArray) Console.WriteLine($"Элемент на позиции {elementPosition}: {array[(elementPosition/10-1), (elementPosition%10-1)]}");
else Console.WriteLine("Такого элемента в массиве нет");