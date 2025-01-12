// See https://aka.ms/new-console-template for more information

//Example 1: Single Inheritance with a Vehicle Class

using System;

// Base Class (Parent)
class Vehicle
{
    public string Brand;

    public void StartEngine()
    {
        Console.WriteLine("The engine is starting...");
    }
}

// Derived Class (Child)
class Car : Vehicle
{
    public int NumberOfDoors;

    public void DisplayCarDetails()
    {
        Console.WriteLine($"This car is a {Brand} and has {NumberOfDoors} doors.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.NumberOfDoors = 4;

        myCar.StartEngine(); 
        myCar.DisplayCarDetails(); 
    }
}
