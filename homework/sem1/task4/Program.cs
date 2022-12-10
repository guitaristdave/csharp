// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using funcs;
Console.Clear();

func.Color("green");
Console.Write("Сколько чисел будем сравнивать? ");
string size = Console.ReadLine();
while(!func.isNatural(size))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попробуйте снова: ");
    func.Color("green");
    size = Console.ReadLine();
}

int[] numbers = new int[int.Parse(size)]; // создаем пустой массив заданной пользователем длины


for (int i = 0; i < numbers.Length; i++) // циклом просим пользователя поочередно ввести то количество чисел, что он задумал.
{
    func.Color("green");
    Console.Write($"Введите {i + 1} число: ");
    string arrayElement = Console.ReadLine();
    while(!func.isNumber(arrayElement))
    {
        func.Color("red");
        Console.Write("Нужно ввести число. Попробуйте снова: ");
        func.Color("green");
        arrayElement = Console.ReadLine();
    }
    numbers[i] = int.Parse(arrayElement);
}

int max = numbers[0]; // объявляем 1-й элемент массива максимальным значением

for (int k = 0; k < numbers.Length; k++) // пробегаемся циклом по массиву, сравнивая поочередно элементы с максимальным и минимальным значениями
{
    if (numbers[k] > max) max = numbers[k];
}

func.Color("magenta");
Console.WriteLine($"Массив: [ {String.Join(", ", numbers)} ]");
Console.WriteLine($"Максимальное значение: {max}");