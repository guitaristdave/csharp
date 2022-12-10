// Повторяются вычисления и вывод площади круга по вводимому радиусу r
// до тех пор, пока не введена буква z или Z .

Console.Write("Введите радиус: ");
string? r = "";
double pi = 3.14;

while (pi == 3.14)
{
    r = Console.ReadLine();
    if (r == "z") break;
    if (r == "Z") break;
    bool dig = Int32.TryParse(r, out int result);
    dig = result > 0 ? true : false;
    if (dig)
    {
        int R = Int32.Parse(r);
        Console.WriteLine($"Радиус равен: {Math.Round((pi * R * R), 2)}");
    }
    Console.Write("Введите радиус: ");
}

Console.WriteLine("Спасибо. Мы вышли из цикла.");

