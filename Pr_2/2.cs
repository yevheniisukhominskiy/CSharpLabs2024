using System;
class Program{
    static void Main()    {
        Console.Write("������ ������� ����� �������: ");
        double side1 = GetPositiveDoubleInput();
        Console.Write("������ ������� ����� �������: ");
        double side2 = GetPositiveDoubleInput();
        Console.Write("������ ������� ������ �������: ");
        double side3 = GetPositiveDoubleInput();
        if (IsTriangleValid(side1, side2, side3))
        {            
	    double perimeter = side1 + side2 + side3;
            double s = perimeter / 2;            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine($"�������� ����������: {perimeter}");
            Console.WriteLine($"����� ����������: {area}");
            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"��������� � {triangleType}.");
        }        
	else
        {            
	    Console.WriteLine("��������� �� ��������� ��������� �� ����.");
        }        
	Console.ReadKey();
    }
    static double GetPositiveDoubleInput()    {
        double input;        while (!double.TryParse(Console.ReadLine(), out input) || input <= 0)
        {            
	    Console.Write("���� �����, ������ �������� ������ �����: ");
        }        
        return input;
    }
    static bool IsTriangleValid(double a, double b, double c)    {
        return a + b > c && a + c > b && b + c > a;    }
    static string GetTriangleType(double a, double b, double c)
    {        
	if (a == b && b == c) return "������������";
        else if (a == b  b == c  a == c) return "������������";
        else return "������������";
    }}