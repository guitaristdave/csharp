// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using funcs;
Console.Clear();

func.Color("green");
Console.Write("Укажите количество элементов в массиве: ");
string? number = Console.ReadLine();

while (!func.isNatural(number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Нужно ввести число больше 0. Попробуйте снова: ");
    number = Console.ReadLine();
}

int size = int.Parse(number);

int[] array = func.getRandomArray(size, 1, 100);

int elementsSum = 0;

for (int i = 1; i < array.Length; i += 2)
{
    elementsSum += array[i];
}

func.Color("magenta");
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях [{String.Join(", ", array)}] = {elementsSum}");