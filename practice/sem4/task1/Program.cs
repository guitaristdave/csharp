// программа принимает на вход число и выводит сумму всех чисел от 1 до N
using learn;

void getSum()
{
    Console.Write("Введите число: ");
    string? number = Console.ReadLine();
    while (!func.isNumber(number))
    {
        Console.Write("Вы ввели не число. Попробуйте снова: ");
        number = Console.ReadLine();
    }
    int numb = int.Parse(number);
    int result = 0;

    for (int i = 1; i <= numb; i++)
    {
        result += i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {numb} = {result}");
}


getSum();