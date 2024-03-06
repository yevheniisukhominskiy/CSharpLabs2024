using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System;

    class Program
    {
        static void Main()
        {
            Point point1 = new Point(0, 0, "A");
            Point point2 = new Point(0, 4, "B");
            Point point3 = new Point(3, 0, "C");

            Figure triangle = new Figure(point1, point2, point3);
            triangle.PerimeterCalculator();

            Point point4 = new Point(5, 0, "D");
            Figure rectangle = new Figure(point1, point2, point3, point4);
            rectangle.PerimeterCalculator();

            Console.ReadLine();
        }
    }

}
