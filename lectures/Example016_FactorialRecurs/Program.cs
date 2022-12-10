int Factorial(int num)
{
    if (num == 1 || num == 0) return 1;
    else return (num * Factorial(num-1));
}

Console.Write(Factorial(5));