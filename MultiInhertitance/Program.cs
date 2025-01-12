// Example 1: Multi-Level Inheritance with Devices

using System;

// Base Class
class Device
{
    public string Brand;
    public void PowerOn()
    {
        Console.WriteLine($"{Brand} device is powering on.");
    }
}

// Intermediate Derived Class
class Smartphone : Device
{
    public void MakeCall()
    {
        Console.WriteLine($"{Brand} smartphone is making a call.");
    }
}

// Further Derived Class
class Smartwatch : Smartphone
{
    public void TrackSteps()
    {
        Console.WriteLine($"{Brand} smartwatch is tracking steps.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Smartwatch (most derived class)
        Smartwatch myWatch = new Smartwatch();
        myWatch.Brand = "Fitbit";

        // Accessing methods from all levels of inheritance
        myWatch.PowerOn();     
        myWatch.MakeCall();     
        myWatch.TrackSteps();   
    }
}



// Example 2: Multi-Level Inheritance with Employees in a Company

using System;

// Base Class
class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
        Console.WriteLine($"{Name} is an employee.");
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

// Intermediate Derived Class
class Manager : Employee
{
    public Manager(string name) : base(name)
    {
        Console.WriteLine($"{Name} is a manager.");
    }

    public void Manage()
    {
        Console.WriteLine($"{Name} is managing a team.");
    }
}

// Further Derived Class
class SeniorManager : Manager
{
    public SeniorManager(string name) : base(name)
    {
        Console.WriteLine($"{Name} is a senior manager.");
    }

    public void MakeStrategicDecisions()
    {
        Console.WriteLine($"{Name} is making strategic decisions.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of SeniorManager (most derived class)
        SeniorManager seniorManager = new SeniorManager("Alice");

        // Accessing methods from all levels of inheritance
        seniorManager.Work();                   
        seniorManager.Manage();                 
        seniorManager.MakeStrategicDecisions(); 
    }
}