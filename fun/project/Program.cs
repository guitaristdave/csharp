using geometry;
using colors;

Console.Clear();

string[] subjects =
{
    "1 - круг",
    "2 - треугольник",
    "3 - квадрат",
    "4 - прямоугольник",
    "5 - параллелограмм",
    "6 - ромб",
    "7 - трапеция"
};

Color.Cyan();
Console.WriteLine("Привет! Я считаю площади геометрических фигур.");
Color.Green();
Console.WriteLine($"Введите номер нужной фигуры: {"\n"}{String.Join("\n", subjects)}");
Color.Cyan();
Console.Write("Посчитай площадь фигуры №: ");
Color.Yellow();
string subjectNum = Console.ReadLine();

while (!Area.isNumber(subjectNum))
{
    Color.Red();
    Console.Write("Нужно ввести число от 1 до 7. Попробуй снова: ");
    Color.Yellow();
    subjectNum = Console.ReadLine();
    Color.Reset();
}

int subject = int.Parse(subjectNum);

switch (subject)
{
    case 1:
        Color.Green();
        Console.Write("Ты выбрал круг. Напиши радиус(см): ");
        Color.Yellow();
        string radius = Console.ReadLine();
        while (!Area.isDouble(radius))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            radius = Console.ReadLine();
        }
        double circleArea = Area.Circle(double.Parse(radius));
        Color.Magenta();
        Console.WriteLine($"Площадь круга  = {circleArea} см2");
        break;

    case 2:
        Color.Green();
        Console.Write("Ты выбрал треугольник. Впиши длину основания (см): ");
        Color.Yellow();
        string sideLength = Console.ReadLine();
        while (!Area.isDouble(sideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            sideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("А теперь введи высоту(см): ");
        Color.Yellow();
        string height = Console.ReadLine();
        while (!Area.isDouble(height))
        {   
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            height = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь треугольника = {Area.Triangle(double.Parse(sideLength), double.Parse(height))} см2");
        break;

    case 3:
        Color.Green();
        Console.Write("Ты выбрал квадрат. Введи длину стороны (см): ");
        Color.Yellow();
        sideLength = Console.ReadLine();
        while (!Area.isDouble(sideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            sideLength = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь квадрата = {Area.Square(double.Parse(sideLength))} см2");
        break;

    case 4:
        Color.Green();
        Console.Write("Ты выбрал прямоугольник. Введи длину первой стороны (см): ");
        Color.Yellow();
        string firstSideLength = Console.ReadLine();
        while (!Area.isDouble(firstSideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            firstSideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("Теперь введи длину второй стороны (см): ");
        Color.Yellow();
        string secondSideLength = Console.ReadLine();
        while (!Area.isDouble(secondSideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            secondSideLength = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь прямоугольника = {Area.Rectangle(double.Parse(firstSideLength), double.Parse(secondSideLength))} см2");
        break;
    case 5:
        Color.Green();
        Console.Write("Ты выбрал параллелограмм. Введи длину основания (см): ");
        Color.Yellow();
        sideLength = Console.ReadLine();
        while (!Area.isDouble(sideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            sideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("А теперь введи высоту(см): ");
        Color.Yellow();
        height = Console.ReadLine();
        while (!Area.isDouble(height))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            height = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь параллелограмма = {Area.Rectangle(double.Parse(sideLength), double.Parse(height))} см2");
        break;

    case 6:
        Color.Green();
        Console.Write("Ты выбрал ромб. Введи длину основания (см): ");
        Color.Yellow();
        sideLength = Console.ReadLine();
        while (!Area.isDouble(sideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            sideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("А теперь введи высоту(см): ");
        Color.Yellow();
        height = Console.ReadLine();
        while (!Area.isDouble(height))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            height = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь ромба = {Area.Rectangle(double.Parse(sideLength), double.Parse(height))} см2");
        break;

    default:
        Color.Green();
        Console.Write("Ты выбрал трапецию. Введи длину первой стороны (см): ");
        Color.Yellow();
        firstSideLength = Console.ReadLine();
        while (!Area.isDouble(firstSideLength))
        {   
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            firstSideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("Теперь введи длину второй стороны (см): ");
        Color.Yellow();
        secondSideLength = Console.ReadLine();
        while (!Area.isDouble(secondSideLength))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            secondSideLength = Console.ReadLine();
        }
        Color.Green();
        Console.Write("А теперь введи высоту(см): ");
        Color.Yellow();
        height = Console.ReadLine();
        while (!Area.isDouble(height))
        {
            Color.Red();
            Console.Write("Нужно ввести число. Попробуй снова: ");
            Color.Yellow();
            height = Console.ReadLine();
        }
        Color.Magenta();
        Console.WriteLine($"Площадь трапеции = {Area.Trapezoid(double.Parse(firstSideLength), double.Parse(secondSideLength), double.Parse(height))} см2");
        break;
}

Color.Reset();
