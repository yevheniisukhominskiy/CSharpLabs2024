using System;

class Program
{
    static void Main()
    {
        Console.Write("������ ������� ����� ������ ����� ��������: ");
        int lastDigit;
        while (!int.TryParse(Console.ReadLine(), out lastDigit) || lastDigit < 0)
        {
            Console.Write("���� �����, ������ �������� �����: ");
        }

        int arraySize = 10 + lastDigit;
        int[] arrayX = new int[arraySize];

        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            arrayX[i] = random.Next(-50, 51);
        }

        Console.Write("������ ����� M: ");
        int M;
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.Write("���� �����, ������ �������� �����: ");
        }

        Console.WriteLine($"����� �:");
        foreach (var element in arrayX)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        Console.WriteLine($"����� M: {M}");
        Console.WriteLine($"����� Y (�������� ����� �� M �� �������):");
        foreach (var element in arrayX)
        {
            if (Math.Abs(element) > M)
            {
                Console.Write($"{element} ");
            }
        }
        Console.WriteLine();
    }
}