using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // Shared queue to store numbers
    private static Queue<int> numberQueue = new Queue<int>();
    private static object lockObject = new object(); // Lock for synchronization
    private static bool isGenerationComplete = false; // Flag to indicate generation completion

    static void Main(string[] args)
    {
        // Create threads for number generation and square calculation
        Thread generatorThread = new Thread(GenerateNumbers);
        Thread squareCalculatorThread = new Thread(CalculateSquares);

        // Start threads
        generatorThread.Start();
        squareCalculatorThread.Start();

        // Wait for threads to complete
        generatorThread.Join();
        squareCalculatorThread.Join();

        Console.WriteLine("Processing completed.");
    }

    static void GenerateNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            lock (lockObject)
            {
                numberQueue.Enqueue(i); // Add the number to the queue
            }
            Thread.Sleep(10); // Simulate some delay in generating numbers
        }

        lock (lockObject)
        {
            isGenerationComplete = true; // Mark generation as complete
        }
    }

    static void CalculateSquares()
    {
        while (true)
        {
            int number = -1;
            bool hasWork = false;

            lock (lockObject)
            {
                if (numberQueue.Count > 0)
                {
                    number = numberQueue.Dequeue(); // Retrieve a number from the queue
                    hasWork = true;
                }
                else if (isGenerationComplete)
                {
                    break; // Exit the loop if work is complete and queue is empty
                }
            }

            if (hasWork)
            {
                int square = number * number; // Calculate the square
                Console.WriteLine($"Number: {number}, Square: {square}");
            }
            else
            {
                Thread.Sleep(5); // No work available, avoid busy waiting
            }
        }
    }
}

static void Work(CancellationToken cancellationToken)
    {
        try
        {
            while (true)
            {
                // Check for cancellation request
                cancellationToken.ThrowIfCancellationRequested();

                // Simulate work
                Thread.Sleep(500);
                Console.WriteLine("Working...");
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Cancellation requested, ending work.");
        }
        finally
        {
            Console.WriteLine("Cleanup code here.");
        }
    }
}