// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


using funcs;

Console.Clear();
int positiveCount = 0;
func.Color("green");
Console.Write("Напишите количество чисел, которое вы хотите ввести: ");
string arraySize = Console.ReadLine();

while (!func.isNatural(arraySize))
{
    func.Color("red");
    Console.Write("Нужно ввести число больше 0. Попрбуйте снова: ");
    arraySize = Console.ReadLine();
    Console.ResetColor();
}

int size = int.Parse(arraySize);

int[] nums = new int[size];

for (int i = 0; i < size; i++)
{
    func.Color("green");
    Console.Write($"Введите {i + 1} число: ");
    string num = Console.ReadLine();
    while (!func.isNumber(num))
    {
        func.Color("red");
        Console.Write("Нужно ввести число. Попробуйте снова: ");
        num = Console.ReadLine();
        Console.ResetColor();
    }
    nums[i] = int.Parse(num);
    if (nums[i] > 0) positiveCount++;
}

func.Color("magenta");
Console.WriteLine($"Чисел больше 0 массиве [{String.Join(", ", nums)}]: {positiveCount}");

