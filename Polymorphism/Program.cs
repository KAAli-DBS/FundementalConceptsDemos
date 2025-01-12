using System;

class Calculator
{  
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Sum of 2 integers: " + calc.Add(5, 10));
        Console.WriteLine("Sum of 3 integers: " + calc.Add(5, 10, 15));
        Console.WriteLine("Sum of 2 doubles: " + calc.Add(5.5, 10.3));
    }
}


using System;
class Animal
{    
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Dog : Animal
{   
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}
class Cat : Animal
{    
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.Speak();  
        myDog.Speak();     
        myCat.Speak();     
    }
}


using System;

interface IVehicle
{
    void StartEngine();
}

class Car : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("The car engine starts.");
    }
}

class Motorcycle : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("The motorcycle engine starts.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle myCar = new Car();
        IVehicle myMotorcycle = new Motorcycle();

        myCar.StartEngine();        
        myMotorcycle.StartEngine(); 
    }
}


using System;
using System.Collections.Generic;

interface IPayment
{
    void ProcessPayment(); 
}


class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment via Credit Card.");
    }
}


class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment via PayPal.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        List<IPayment> payments = new List<IPayment>
        {
            new CreditCardPayment(),
            new PayPalPayment(),
            new CreditCardPayment(), 
        };

       
        foreach (var payment in payments)
        {
            payment.ProcessPayment();
        }
    }
}