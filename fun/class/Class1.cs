namespace geometry;

public class Area
{
    public static double Circle(double radius)
    {
        double result = Math.Round((Math.PI * Math.Pow(radius, 2)), 3);
        return result;
    }

    public static double Triangle(double sideLength, double height)
    {
        double result = Math.Round((0.5 * sideLength * height), 3);
        return result;
    }

    public static double Square(double sideLength)
    {
        double result = Math.Round((Math.Pow(sideLength, 2)), 3);
        return result;
    }

    public static double Rectangle(double firstSideLength, double secondSideLength)
    {
        double result = Math.Round((firstSideLength * secondSideLength), 3);
        return result;
    }

    public static double Parallelogram(double sideLength, double height)
    {
        double result = Math.Round((sideLength * height), 3);
        return result;
    }

    public static double Rhombus(double sideLength, double height)
    {
        double result = Math.Round((sideLength * height), 2);
        return result;
    }

    public static double Trapezoid(double firstSideLength, double secondSideLength, double height)
    {
        double result = Math.Round((0.5 * height * (firstSideLength + secondSideLength)), 2);
        return result;
    }

    public static bool isNumber(string number)
    {
        bool result = int.TryParse(number, out int num);
        if(num < 1 || num > 7) result = false;
        return result;
    }

    public static bool isDouble(string number)
    {
        bool result = double.TryParse(number, out double num);
        result = num > 0? true : false;
        return result;
    }
}
