using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть останню цифру номера групи студента: ");
        int lastDigit;
        while (!int.TryParse(Console.ReadLine(), out lastDigit) || lastDigit < 0)
        {
            Console.Write("Будь ласка, введіть коректну цифру: ");
        }

        int arraySize = 10 + lastDigit;
        int[] arrayX = new int[arraySize];

        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            arrayX[i] = random.Next(-50, 51);
        }

        Console.Write("Введіть число M: ");
        int M;
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.Write("Будь ласка, введіть коректне число: ");
        }

        Console.WriteLine($"Масив Х:");
        foreach (var element in arrayX)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Число M: {M}");
        Console.WriteLine($"Масив Y (елементи більше за M за модулем):");
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