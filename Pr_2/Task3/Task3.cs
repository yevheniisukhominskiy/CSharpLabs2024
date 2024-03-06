using System;
class Program
{
    static void Main()
    {
        int[] array = new int[30];
        Random random = new Random(); 
        for (int i = 0; i < 30; i++)
            array[i] = random.Next(1, 101);
        int min = array[0], max = array[0]; 
        foreach (var element in array)
        {
            if (element < min) min = element;
            if (element > max) max = element;
        }
        Console.WriteLine("Масив Х:");
        PrintArray(array);
        Console.WriteLine($"Мінімальне значення: {min}"); 
        Console.WriteLine($"Максимальне значення: {max}");
        Console.ReadKey();
    }
    static void PrintArray(int[] array)
    {
        foreach (var element in array)
            Console.Write($"{element} "); Console.WriteLine();
    }
}