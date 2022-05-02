using System;
using System.Collections.Generic;
using System.Text;

namespace _1_MethodOverloading
{
    public static class Calculator
    {
        public static int GetSumm(int a, int b) => a + b;              // метод вычисления суммы
        public static int GetSumm(int a, int b, int c) => a + b + c;   // перегруженный метод вычисления суммы
        public static double GetSumm(int a, double b) => a + b;        // перегруженный метод вычисления суммы с разными типами
        public static double GetSumm(double a, int b) => a + b;        // 2 вариант перегрузки с разными типами

        public static double GetSumm(double a, double b) => a + b;
        public static double GetSumm(double a, double b, double c)
        {
            return GetSumm(a, b) + c;       //  вызов перегруженной версии метода 
        }

        public static void PrintSumm(int a, int b) => Console.WriteLine(a+b);
        public static void PrintSumm(int a, double c) => Console.WriteLine(c+a);

    }
}
