// // Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

using funcs;

Console.Write("Задайте длину массива: ");
string number = Console.ReadLine();

while(!func.isNatural(number))
{
    Console.Write("Нужно ввести натуральное число. Попробуйте снова: ");
    number = Console.ReadLine();
}
int size = int.Parse(number);

int[] array = func.getRandomArray(size, 0, 100);
Console.WriteLine($" [ {String.Join(", ", array)} ]");
