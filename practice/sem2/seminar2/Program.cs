// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a !=0 && b != 0)
{
    if (a > b)
{
    if (a % b == 0) 
    {
        Console.WriteLine($"{a} кратно {b}");
    }
    else
    {
        Console.WriteLine(a % b);
    }
}

if (a < b)
{
    if (b % a == 0) 
    {
        Console.WriteLine($"{b} кратно {a}");
    }
    else
    {
        Console.WriteLine(b % a);
    }
}
}
else
{
    Console.WriteLine("Ваше число равно нулю. Введите другое");
}