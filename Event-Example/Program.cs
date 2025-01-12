using System;

public class SampleEventArgs
{
    public SampleEventArgs(string text) { Text = text; }
    public string Text { get; } // readonly
}

public class Publisher
{
    // Declare the delegate (if using non-generic pattern).
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);

    // Declare the event.
    public event SampleEventHandler SampleEvent;

    // Wrap the event in a protected virtual method
    // to enable derived classes to raise the event.
    
    protected virtual void RaiseSampleEvent()
    {
        // Raise the event in a thread-safe manner using the ?. operator.
        SampleEvent?.Invoke(this, new SampleEventArgs("Hello, world!"));
    }

    public void TriggerEvent()
    {
        Console.WriteLine("Triggering the SampleEvent...");
        RaiseSampleEvent(); // Raise the event
    }
}

public class Subscriber
{
    private readonly string _name;

    public Subscriber(string name, Publisher publisher)
    {
        _name = name;
        // Subscribe to the event
        publisher.SampleEvent += HandleEvent;
    }

    // Event handler
    private void HandleEvent(object sender, SampleEventArgs e)
    {
        Console.WriteLine($"{_name} received event with message: {e.Text}");
    }
}

public class Program
{
    public static void Main()
    {
        Publisher publisher = new Publisher();

        // Creating multiple subscribers
        Subscriber subscriber1 = new Subscriber("Subscriber 1", publisher);
        Subscriber subscriber2 = new Subscriber("Subscriber 2", publisher);

        // Trigger the event
        publisher.TriggerEvent();
    }
}
