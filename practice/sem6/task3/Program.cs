

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Сколько чисел Фибоначчи вывести? ");
int size = int.Parse(Console.ReadLine());

double[] fibs = new double[size];

for (int j = 0; j < 2; j++)
{
    fibs[j] = j;
}

for(int i = 2; i < fibs.Length; i++)
{
    fibs[i] = fibs[i-1] + fibs[i-2];
}

Console.WriteLine($"Первые {size} чисел Фибоначчи: [ {String.Join(",", fibs)} ]");