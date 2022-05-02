using System;

namespace _2_ConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Nissan");
            Car car3 = new Car("Toyota", "Camry");
            Car car4 = new Car("Kia", "Rio", 2020);


        }
    }
}
