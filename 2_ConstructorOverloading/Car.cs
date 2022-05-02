using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ConstructorOverloading
{
    internal class Car
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }

        public Car ()
        {
            Console.WriteLine("модель / бренд не известны");
        }

        public Car (string m)   //перегрузка конструктора
        {
            Brand = m;
            Console.WriteLine($"Марка автомобиля: {Brand} модель неизвестна");
        }

        public Car (string m, string n) //2 перегрузка конструктора
        {
            Brand = m;
            Model = n;
            Console.WriteLine($"Марка автомобиля: {Brand} модель {Model}");
        }

        public Car (string m, string n, int y) //3 перегрузка конструктора
        : this(m, n)
        {
            Year = y;
            Console.WriteLine($"{Year} года выпуска");
        }
    }
}
