Console.Clear(); // Очищаем терминал
int count = 0; // Задаем счетчик пробежек собаки
Console.WriteLine("Введите расстояние (м)"); // Спрашиваем расстояние
int distance = Convert.ToInt32(Console.ReadLine()); // Получаем расстояние
Console.WriteLine("Введите скорость 1-го друга (м/с)"); // Спрашиваем скорость 1-го друга
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine()); // Получаем скорость 1-го друга
Console.WriteLine("Введите скорость 2-го друга (м/с)"); // Спрашиваем скорость 2-го друга
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine()); // Получаем скорость 2-го друга
Console.WriteLine("Введите скорость собаки (м/с)"); // Спрашиваем скорость собаки
int dogSpeed = Convert.ToInt32(Console.ReadLine()); // Получаем скорость собаки
int friend = 2; // Переменная для указания направления бег собаки (от 1 ко 2 или наоборот)

while(distance>10) // цикл будет идти до тех пор, пока расстояние между друзьями не уменьшится до 10 метров
{
    if(friend == 2) // вычисления, если собака бежит от 1 друга ко 2
    {
        int time = distance / (secondFriendSpeed + dogSpeed); // вычисляем время
        friend = 1; // меняем переменную, чтобы сообщить, что направление собаки поменяется
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time; // корректируем дистанцию между друзьями
        count++; // увеличивем счетчик пробежек на 1
    }
    else // вычисления, если собака бежит от 2 друга к 1
    {
        int time = distance / (firstFriendSpeed + dogSpeed); // вычисляем время
        friend = 2; // меняем направление собаки
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time; // корректируем дистанцию
        count++; // увеличиваем счетчик пробежек
    }
}

Console.WriteLine("Собака пробежит " + count + " раз"); // выводим итоговое количество пробежек

