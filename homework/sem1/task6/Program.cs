//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using funcs;
Console.Clear();

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

func.Color("magenta");

if (func.isEven(int.Parse(number))) Console.WriteLine($"{number} - четное");
else Console.WriteLine($"{number} - нечетное");
