using System;
using System.Collections.Generic;
using System.Text;

namespace _3_OperationOverloading
{
    /// <summary>
    /// класс, описывающий точку на координатной плоскости
    /// </summary>
    public class Point
    {
        public int x,y;

        public Point(int x = 0, int y = 0)
        {
            this.x=x;
            this.y=y;
        }

        public override string ToString()
        {
            return $"точка {x}.{y}";
        }

        public static Point operator + (Point p1, Point p2) //перегрузка сложения точек
        {
            Point resultPont = new Point();
            resultPont.x = p1.x + p2.x;
            resultPont.y = p1.y + p2.y; 

            return resultPont;
        }

        public static Point operator - (Point p1, Point p2) //перегрузка разности точек
        {
            Point resultPont = new Point();
            resultPont.x = p1.x - p2.x;
            resultPont.y = p1.y - p2.y;

            return resultPont;
        }

    }
}
