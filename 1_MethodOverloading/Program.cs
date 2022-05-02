/*
 * демонстрация перегрузки метода внутри класса
 */
using System;
using static _1_MethodOverloading.Calculator; //подключение содержимого класса Calculator к текущему классу

namespace _1_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int x = 10, y = 15, intRes;
            double m = 1.5, n = 2.0, dobRes;

            //прямой вызов метода из другого класса
            intRes = GetSumm(x, y);        //25
            intRes = GetSumm(x, y, 10);    //35

            dobRes = GetSumm(x, m);        //11.5
            dobRes = GetSumm(n, y);         //17.0

            
        }
    }
}
