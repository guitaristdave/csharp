// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

bool isNumber (string? number)
{
    bool result = int.TryParse(number, out int digit);
    return result;
}

Console.Write("Введите число: ");
string? number = Console.ReadLine();

while(!isNumber(number))
{
    Console.Write("Ошибка. Нужно ввести число. Попробуйте снова: ");
    number = Console.ReadLine();
}

int num = int.Parse(number);

Console.Write($"Кубы чисел от {1} до {num}: ");

for (int i = 1; i < num ; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}

Console.Write($"{Math.Pow(num, 3)}.");