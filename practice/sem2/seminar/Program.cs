//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// / Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10,100);
// Console.WriteLine(number);

// if (number/10 > number%10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
//     Console.WriteLine(number%10);
// }


int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int x1 = number/100;
int x2 = number%10;

Console.WriteLine($"{x1}{x2}");
