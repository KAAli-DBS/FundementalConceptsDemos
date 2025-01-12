using System;

namespace EventDrivenExample
{
    // We can add this part in our Databaseoperations.cs file with DB operations 
    
    // Define a delegate for the event handler
    public delegate void CustomerAddedEventHandler(object sender, EventArgs e);

    // Class to represent the event and event handling
    public class CustomerDatabase
    {
        // Declare the event using the delegate
        public event CustomerAddedEventHandler CustomerAdded;

        public void AddCustomer(string firstName, string lastName, string email)
        {
            // Logic to add customer to database
            Console.WriteLine($"Customer {firstName} {lastName} added.");

            // Raise the CustomerAdded event
            //Calling The Event
            OnCustomerAdded(EventArgs.Empty);
        }

        // Method to raise the event
        protected virtual void OnCustomerAdded(EventArgs e)
        {
            // If there are any subscribers to the event, raise it
            //Event is Invoked here
            CustomerAdded?.Invoke(this, e);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerDatabase customerDatabase = new CustomerDatabase();

            // Subscribe to the CustomerAdded event
            customerDatabase.CustomerAdded += CustomerDatabase_CustomerAdded;

            // Add a customer to trigger the event
            customerDatabase.AddCustomer("John", "Doe", "john@example.com");
        }

        // Event handler method
        // We can add it in Default.aspx.cs file of our Web Application 
        private static void CustomerDatabase_CustomerAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Customer added event occurred.");
        }
    }
}


using System;
namespace EventDrivenExample
{
    //EVENT HANDLER
    // and also how should be the EVENT HANDLER should look like 
    public delegate void CustomerAddedEventHandler(object sender, EventArgs e);
    
    public class CustomerDatabase
    {
        //EVENT name is CustomerAdded
        public event CustomerAddedEventHandler CustomerAdded;
        
        public void AddCustomer(string firstName, string lastName, string email)
        {  
            Console.WriteLine($"Customer {firstName} {lastName} added.");
            OnCustomerAdded(EventArgs.Empty);
        }
        protected virtual void OnCustomerAdded(EventArgs e)
        {
            CustomerAdded?.Invoke(this, e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDatabase customerDatabase = new CustomerDatabase();
            // EVENT LISTENER += Subscribe to the EVENT
            // CustomerDatabase_CustomerAdded is the method that will be executed 
            // when the event is triggered.
            //CustomerDatabase_CustomerAdded This is also EVENT HANDLER matches the delegate 
            
            customerDatabase.CustomerAdded += CustomerDatabase_CustomerAdded; 
            
            
            customerDatabase.AddCustomer("John", "Doe", "john@example.com");
        }
        // CALLBACK FUNCTION
        private static void CustomerDatabase_CustomerAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Customer added event occurred.");
        }
    }
}

// You add a customer using customerDatabase.AddCustomer("John", "Doe", "john@example.com").
// Inside AddCustomer, the event CustomerAdded is raised using OnCustomerAdded(EventArgs.Empty).
// The event listener (CustomerDatabase_CustomerAdded) reacts to this event, invoking the callback function.
// The CustomerDatabase_CustomerAdded method is executed, printing "Customer added event occurred."
