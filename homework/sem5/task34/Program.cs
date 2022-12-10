// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using funcs;
Console.Clear();
func.Color("green");
Console.Write("Укажите количество чисел в массиве: ");
string number = Console.ReadLine();

while (!func.isNatural(number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Нужно ввести число больше 0. Попробуйте снова ");
    number = Console.ReadLine();
}

int size = int.Parse(number);

int[] array = func.getRandomArray(size, 100, 1000);

int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
    if (func.isEven(array[i])) ++evenCount;
}

func.Color("magenta");
Console.WriteLine($"Количество четных чисел в массиве [{String.Join(", ", array)}] = {evenCount}");

