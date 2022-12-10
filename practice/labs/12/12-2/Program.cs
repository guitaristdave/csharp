// вычисляется сумма квадратов n натуральных чисел, начиная с k. (k и n вводятся с клавиатуры, цикл for)

Console.Write("Напиши, сколько чисел нужно возвести в квадрат: ");
string? n = Console.ReadLine();

bool count1 (string? n)
{
    bool result = int.TryParse(n, out int num);
    result = num > 0 ? true : false;
    return result;
}
bool count2 (string? n)
{
    bool result = int.TryParse(n, out int num);
    return result;
}
while (!count1(n))
{
    Console.Write("Нужно ввести число больше 0. Попробуй снова:");
    n = Console.ReadLine();
}

Console.Write("С какого числа начать? ");
string? k = Console.ReadLine();

while (!count2(k))
{
    Console.Write("Нужно ввести число. Попробуй снова:");
    k = Console.ReadLine();
}




int N = Int32.Parse(n);
int K = Int32.Parse(k);

for (int i = K; i < (K+N); i++)
{
    Console.Write($"{i * i} ");
}
