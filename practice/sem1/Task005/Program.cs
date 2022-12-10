// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

bool Numb(string? number)
{
    bool result = int.TryParse(number, out int num);
    result = (num > 99 && num < 1000) ? true : false;
    return result;
}

Console.Write("Введите трехзначное число: ");
string? number = Console.ReadLine();

while (!Numb(number))
{
    Console.Write("Введенное числе не трехзначное. Попробуйте снова: ");
    number = Console.ReadLine();
}

int x = Int32.Parse(number);

Console.WriteLine("Последняя цифра числа: " + x % 10);
