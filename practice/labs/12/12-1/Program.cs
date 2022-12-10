// вывести на экран все нечетные числа от n1 до n2. Ввод с клавиатуры, цикл for


bool Enter (string? n)
{
    bool result = int.TryParse(n, out int num);
    return result;
}

Console.Write("Введите 1 число: ");
string? num1 = Console.ReadLine();

while (!Enter(num1))
{
    Console.Write("Вы ввели не число. Попробуйте снова: ");
    num1 = Console.ReadLine();
}

Console.Write("Введите 2 число: ");
string? num2 = Console.ReadLine();

while (!Enter(num2))
{
    Console.Write("Вы ввели не число. Попробуйте снова: ");
    num2 = Console.ReadLine();
}

int n1 = Int32.Parse(num1);
int n2 = Int32.Parse(num2);

if (n1 > n2) (n1, n2) = (n2, n1);
if (n1 % 2 == 0) ++n1;
for (int i = n1; i <= n2; i += 2)
{
    Console.Write($"{i} ");
}



