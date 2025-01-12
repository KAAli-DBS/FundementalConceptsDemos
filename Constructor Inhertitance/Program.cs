// See https://aka.ms/new-console-template for more information


//Example 2: Constructor Usage in Single Inheritance (Company Example)

using System;

// Base Class (Parent)
class Employee
{
    public string Name;

    // Base class constructor
    public Employee(string name)
    {
        Name = name;
        Console.WriteLine($"Employee {name} has been created.");
    }
}

// Derived Class (Child)
class Manager : Employee
{
    public int TeamSize;

    // Derived class constructor
    public Manager(string name, int teamSize) : base(name)
    {
        TeamSize = teamSize;
        Console.WriteLine($"{Name} manages a team of {TeamSize} people.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Alice", 10);
    }
}