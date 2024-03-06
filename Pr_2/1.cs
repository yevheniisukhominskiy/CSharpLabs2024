using System;
namespace ConsoleApp2{
    class Program    {
        static void Main(string[] args)        {
            int a, b, c;            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("[1, 30]: ");
            if (IsInInterval(a)) Console.WriteLine(a);
            if (IsInInterval(b)) Console.WriteLine(b);
            if (IsInInterval(c)) Console.WriteLine(c);
            Console.ReadKey();
        }
        static bool IsInInterval(int num)        {
            return num >= 1 && num <= 30;        }
    }}