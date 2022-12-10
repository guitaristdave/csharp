// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using funcs;
Console.Clear();


string DigPlus (int a)
{
    string result = "";
    if (a % 2 != 0) --a;
    for (int i = 2; i <= a; i += 2)
    {
        result = result + $"{i} ";
    }
    return result;

}

string DigMinus (int a)
{
    string result = "";
    if (a % 2 != 0) ++a;
    for (int i = 0; i >= a; i -= 2)
    {
        result = result + $"{i} ";
    }
    return result;

}

func.Color("green");
Console.Write("Введите число: ");
string number = Console.ReadLine();

while(!func.isNumber(number))
{
    func.Color("red");
    Console.Write("Нужно ввести число. Попробуйте снова: ");
    func.Color("green");
    number = Console.ReadLine();
}

int  num = int.Parse(number);

func.Color("magenta");
if (num > 1) Console.Write(DigPlus(num));
if (num < 1) Console.Write(DigMinus(num));
if (num == 0 || num == Math.Abs(1)) Console.Write(0);

