// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
bool Digit (string? number)
{
    bool result = int.TryParse(number, out int num);
    return result;
}

Console.Write("Введите число: ");
string? number = Console.ReadLine();

while (!Digit(number))
{
    Console.Write("Это не число. Введите число: ");
    number = Console.ReadLine();
}

int count = -(Int32.Parse(number));
int x = Int32.Parse(number);

while (count < x + 1)
{
    Console.Write(count + " ");
    count++;
}
