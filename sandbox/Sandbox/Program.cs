using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");


        Car car1 = new Car();

        car1._brand = "Ford";
        car1._model = "Raptor";
        car1._year = 2020;

        car1.Move();
    }
}