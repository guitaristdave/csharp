// вычисляем и выводим с шагом в 10 км расход бензина на (10-90 км). расход и цена бензина вводятся с клавиатуры, for

bool benz (string? n)
{
    bool result = double.TryParse(n, out double num);
    result = num > 0 ? true : false;
    return result;
}

Console.Write("Введите расход бензина на 100 км: ");
string? b = Console.ReadLine();

while (!benz(b))
{
    Console.Write("Ошибка. Попробуйте заново: ");
    b = Console.ReadLine();
}

Console.Write("Введите стоимось бензина за 1 л: ");
string? c = Console.ReadLine();

while (!benz(c))
{
    Console.Write("Ошибка. Попробуйте заново: ");
    c = Console.ReadLine();
}

double B = double.Parse(b);
double C = double.Parse(c);

for (int i = 10; i <= 90; i += 10)
{
    Console.WriteLine($"{i} км поездки стоят {B * i / 100 * C} рублей");
}