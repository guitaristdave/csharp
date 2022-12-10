//Вычисление функции Аккермана с помощью рекурсии

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

// Не стал делать отдельный ввод с клавиатуры, тк почти любые значения вызывают stack overflow

int ackerm = Ackermann(4, 2);
Console.WriteLine(ackerm);