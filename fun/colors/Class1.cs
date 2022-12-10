namespace colors;
public class Color
{
    public static void Red()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void Green()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void Magenta()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }

    public static void Cyan()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public static void Yellow()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    public static void Reset()
    {
        Console.ResetColor();
    }
}
