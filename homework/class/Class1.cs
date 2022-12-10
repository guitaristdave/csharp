namespace funcs;
public class func
{
    //проверяет, является ли введенное число натуральным
    public static bool isNatural(string? number)
    {
        bool result = int.TryParse(number, out int num);
        result = num > 0 ? true : false;
        return result;
    }

    // проверяет, является ли введенное числом, больше moreThan
    public static bool isNum(string number, int moreThan)
    {
        bool result = int.TryParse(number, out int num);
        result = num > moreThan ? true : false;
        return result;
    }

    //проверяет, является ли введенное число double
    public static bool isDouble(string? number)
    {
        bool result = double.TryParse(number, out double num);
        return result;
    }

    //проверяет, является ли введенное числом
    public static bool isNumber(string? number)
    {
        bool result = int.TryParse(number, out int num);
        return result;
    }

    // возводит a в степень b (b >= 0)
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }
        return result;
    }

    // создание целочисленного массива длиной = size с числами от x до y-1
    public static int[] getRandomArray(int size, int x, int y)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(x, y);
        }
        return result;
    }

    // проверяет ввод на число и требует ввести его, если введено что-то другое. Возвращает в итоге число
    public static int checkNum(string? number)
    {
        while (!int.TryParse(number, out int num))
        {
            Console.Write("Нужно ввести число. Попробуйте снова: ");
            number = Console.ReadLine();
        }
        int x = int.Parse(number);
        return x;

    }

    public static bool isEven(int num)
    {
        if (num % 2 == 0) return true;
        else return false;
    }


    public static void Color(string color)
    {
        if (color == "green") Console.ForegroundColor = ConsoleColor.Green;
        else if (color == "red") Console.ForegroundColor = ConsoleColor.Red;
        else if (color == "yellow") Console.ForegroundColor = ConsoleColor.Yellow;
        else if (color == "cyan") Console.ForegroundColor = ConsoleColor.Cyan;
        else if (color == "magenta") Console.ForegroundColor = ConsoleColor.Magenta;
    }

    public static double[,] GetRandomDoubleTwoDimArray(int row, int column)
    {
        double[,] result = new double[row, column];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                int multiply = new Random().Next(10, 50);
                result[i, j] = new Random().NextDouble() * (multiply);
            }
        }
        return result;
    }

    public static int[,] GetRandomTwoDimArray(int row, int column, int from, int to)
    {
        int[,] result = new int[row, column];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = new Random().Next(from, to); ;
            }
        }
        return result;
    }
    public static void PrintDoubleTwoDimArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]:f2}  ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] GetRandomTwoDimArray(int row, int column)
    {
        int[,] result = new int[row, column];
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = new Random().Next(10, 100);
            }
        }
        return result;
    }
    public static void PrintTwoDimArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }
    }

    public static double Average(double[] array)
    {
        double arraySum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            arraySum += array[i];
        }
        return Math.Round((arraySum / array.Length), 2);
    }

    public static int[,,] Create3dArray(int width, int height, int depth)
    {
        int[,,] result = new int[width, height, depth];
        int number = 10;

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < result.GetLength(2); k++)
                {
                    result[i, j, k] = number++;
                }
            }
        }

        return result;
    }
    public static int Number()
    {
        func.Color("yellow");
        string? number = Console.ReadLine();
        while (!int.TryParse(number, out int num) || num < 1)
        {
            func.Color("red");
            Console.Write("Нужно ввести число больше 0, Попробуйте снова: ");
            func.Color("yellow");
            number = Console.ReadLine();
        }
        int result = int.Parse(number);
        return result;
    }

    public static int[,] MatrixMultiply(int[,] matrix1, int[,] matrix2)
    {

        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
