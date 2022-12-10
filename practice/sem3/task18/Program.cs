// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).



int quater = 0;

do 
{
    Console.WriteLine("Введите номер четверти: ");
    quater = Convert.ToInt32(Console.ReadLine());
}
while (quater < 1 || quater > 4);

if(quater == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(quater == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}

else if(quater == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}

else
{
    Console.WriteLine("x > 0 && y < 0");
}