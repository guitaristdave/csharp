// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using funcs;
Console.Clear();

func.Color("green");
Console.Write("Сколько чисел будем сравнивать? ");
string? size = Console.ReadLine();

while(!func.isNatural(size))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. попробуйте снова: ");
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
        Console.Write("Нужно ввести число. попробуйте снова: ");
        func.Color("green");
        arrayElement = Console.ReadLine();
    }
    numbers[i] = int.Parse(arrayElement);
}

int max = numbers[0]; // объявляем 1-й элемент массива максимальным значением
int min = numbers[0]; // объявляем 1-й элемент массива минимальным значением

for (int k = 0; k < numbers.Length; k++) // пробегаемся циклом по массиву, сравнивая поочередно элементы с максимальным и минимальным значениями
{
    if (numbers[k] > max) max = numbers[k];
    if (numbers[k] < min) min = numbers[k];
}
func.Color("magenta");
Console.WriteLine($"Массив: [ {String.Join(", ", numbers)} ]");
Console.WriteLine($"Максимальное значение: {max}, минимальние значение: {min}");







