// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using funcs;

Console.Clear();
func.Color("green");
Console.Write("Введите количество элементов массива: ");
string? number = Console.ReadLine();

while (!func.isNatural(number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Нужно ввести число больше 0. Попробуйте снова: ");
    number = Console.ReadLine();
}

int size = int.Parse(number);

int[] array = func.getRandomArray(size, -100, 100);


int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}

int elementsDiff = max - min;

func.Color("magenta");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: [{String.Join(", ", array)}] = {elementsDiff}");