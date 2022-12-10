// Задайте значения m и n. напишите программму, которая найдет сумму натуральных элементов от m до n.

using funcs;
Console.Clear();

func.Color("yellow");
Console.WriteLine("Задайте значения m и n. программа выведет все натуральные числа от m до n.");
Console.WriteLine();

func.Color("green");
Console.Write("Введите число M: ");
int m = func.Number();

func.Color("green");
Console.Write("Введите число N: ");
int n = func.Number();



func.Color("magenta");

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    else return m + SumNumbers(m + 1, n);
}

int result = 0;

if (m < n)  result = SumNumbers(m, n);
else result = SumNumbers(n, m);

Console.WriteLine($"Сумма чисел от {m} до {n} = {result}");
