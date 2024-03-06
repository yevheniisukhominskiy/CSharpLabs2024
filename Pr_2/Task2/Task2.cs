using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину першої сторони: "); 
        double side1 = GetPositiveDoubleInput();
        Console.Write("Введіть довжину другої сторони: ");
        double side2 = GetPositiveDoubleInput();
        Console.Write("Введіть довжину третьої сторони: "); 
        double side3 = GetPositiveDoubleInput();
        if (IsTriangleValid(side1, side2, side3))
        {
            double perimeter = side1 + side2 + side3;
            double s = perimeter / 2; 
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");
            string triangleType = GetTriangleType(side1, side2, side3); 
            Console.WriteLine($"Трикутник є {triangleType}.");
        }
        else
        {
            Console.WriteLine("Трикутник із введеними сторонами не існує.");
        }
        Console.ReadKey();
    }
    static double GetPositiveDoubleInput()
    {
        double input; while (!double.TryParse(Console.ReadLine(), out input) || input <= 0)
        {
            Console.Write("Будь ласка, введіть коректне додатнє число: ");
        }
        return input;
    }
    static bool IsTriangleValid(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c) return "рівносторонній";
        else if (a == b || b == c || a == c) return "рівнобедрений";        
        else return "різносторонній";
    }
}