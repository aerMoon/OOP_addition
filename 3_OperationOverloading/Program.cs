using System;

namespace _3_OperationOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);

            Console.WriteLine(point1+point2);
            Console.WriteLine(point2-point1);
        }
    }
}
