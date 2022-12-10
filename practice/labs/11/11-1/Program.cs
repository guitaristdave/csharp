// // вводится случайное число [20 - 99] и проверяется делится ли оно на введенное с клавиатуры n

// void Number (int divide)
// {
//     Console.Write("Введите делитель: ");
//     int x = int.Parse(Console.ReadLine());
//     string result = Console.WriteLine(divide % x == 0 ? $"Да, {divide} делится на {x} без остатка." : $"Нет, {divide} не делится на {x} без остатка.");
//     return result;
// }

// int divide = new Random().Next(20, 100);

// Console.WriteLine(Number(divide));