using System;
class Program
{
    static void Main()
    {
        int[] array = new int[30];
        Random random = new Random(); for (int i = 0; i < 30; i++)
        {
            array[i] = random.Next(-50, 51);
        }
        Console.Write("Введіть число M: "); int M;
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.Write("Будь ласка, введіть коректне число: ");
        }
        Console.WriteLine("Масив Х:");
        foreach (var element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Число M: {M}"); Console.WriteLine($"Масив Y (елементи більше за {M} за модулем):");
        foreach (var element in array)
        {
            if (element > Math.Abs(M))
            {
                Console.Write($"{element} ");
            }
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}