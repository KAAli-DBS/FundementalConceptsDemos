/*
Enqueue: The Enqueue method adds elements based on priority by shifting elements with lower priorities to the right.
Dequeue: The Dequeue method removes the element with the highest priority, which is at the end of the array.
Peek: This retrieves the element with the highest priority without removing it.

The numbers 1, 2, and 3 are priority values associated with each item in the queue. In this context:
10 has a priority of 2.
20 has a priority of 1.
30 has a priority of 3.
*/

using System;

class PriorityQueueArray
{
    private int[] data;
    private int[] priorities;
    private int maxSize;
    private int size;
    public PriorityQueueArray(int capacity)
    {
        maxSize = capacity;
        data = new int[maxSize];
        priorities = new int[maxSize];
        size = 0;
    }
    public void Enqueue(int item, int priority)
    {
        if (size == maxSize)
        {
            Console.WriteLine("Priority Queue is full!");
            return;
        }

        int i;
        for (i = size - 1; i >= 0; i--)
        {
            // Shift lower-priority elements
            if (priority < priorities[i])
            {
                data[i + 1] = data[i];
                priorities[i + 1] = priorities[i];
            }
            else
            {
                break;
            }
        }
        
        data[i + 1] = item;
        priorities[i + 1] = priority;
        size++;
    }
    public int Dequeue()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Priority Queue is empty!");
        }
        return data[--size];
    }
    public bool IsEmpty() => size == 0;
    public int Peek()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("Priority Queue is empty!");
        }
        return data[size - 1];
    }
}
class Program
{
    static void Main()
    {
        PriorityQueueArray pq = new PriorityQueueArray(5);
        pq.Enqueue(10, 2);
        pq.Enqueue(20, 1);
        pq.Enqueue(30, 3);

        Console.WriteLine("Dequeue: " + pq.Dequeue()); 
        Console.WriteLine("Peek: " + pq.Peek());       
    }
}

