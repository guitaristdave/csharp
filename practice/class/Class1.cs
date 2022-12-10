namespace learn;
public class func
{
    // возвращает true, если введено целое число
    public static bool isNumber(string number)
    {
        bool result = int.TryParse(number, out int num);
        return result;
    }

    public static int[] getRandomArray(int size, int x, int y)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(x, y);
        }
        return result;
    }

    public static double[,] GetRandomTwoDimArray(int row, int column, int min, int max)
    {
        double[,] result = new double[row, column];
        for(int i = 0; i < row; i++)
        {
            for (int k = 0; i < column; k++)
            {
                int multiply = new Random().Next(min, max);
                result[i, k] = new Random().NextDouble() * multiply;
            }
        }
        return result;
    }

    public static void PrintTwoDimArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; i < array.GetLength(1); k++)
            {
                Console.Write($"{array[i, k]:f2}");
            }
            Console.WriteLine();
        }
    }
}
