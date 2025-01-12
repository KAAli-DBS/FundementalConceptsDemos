/*
Enqueue: Nodes are inserted based on priority, with lower values indicating higher priority.
Dequeue: The node with the highest priority (head of the list) is removed.
Peek: Returns the value of the head node without removing it, as it has the highest priority.
*/


class Node
{
    public int Data { get; set; }
    public int Priority { get; set; }
    public Node Next { get; set; }

    public Node(int data, int priority)
    {
        Data = data;
        Priority = priority;
        Next = null;
    }
}

class PriorityQueueLinkedList
{
    private Node head;

    public PriorityQueueLinkedList()
    {
        head = null;
    }

    public void Enqueue(int data, int priority)
    {
        Node newNode = new Node(data, priority);

        if (head == null || priority < head.Priority)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Priority <= priority)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public int Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Priority Queue is empty!");
        }

        int highestPriorityData = head.Data;
        head = head.Next;
        return highestPriorityData;
    }

    public bool IsEmpty() => head == null;

    public int Peek()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Priority Queue is empty!");
        }
        return head.Data;
    }
}

// Usage
class Program
{
    static void Main()
    {
        PriorityQueueLinkedList pq = new PriorityQueueLinkedList();
        pq.Enqueue(10, 2);
        pq.Enqueue(20, 1);
        pq.Enqueue(30, 3);

        Console.WriteLine("Dequeue: " + pq.Dequeue()); // Output: 20
        Console.WriteLine("Peek: " + pq.Peek());       // Output: 10
    }
}