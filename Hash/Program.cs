using System;
using System.Collections.Generic;

class Hash
{
    int BUCKET; 

    // List of integers to store values
    List<int>[] table;

    public Hash(int V)
    {
        this.BUCKET = V;
        table = new List<int>[BUCKET];
        for (int i = 0; i < BUCKET; i++)
            table[i] = new List<int>();
    }

    // Hash function to map values to key
    int hashFunction(int x)
    {
        return (x % BUCKET);
    }

    // Inserts a key into the hash table
    public void insertItem(int key)
    {
        int index = hashFunction(key);
        table[index].Add(key);
    }

    // Deletes a key from the hash table
    public void deleteItem(int key)
    {
        int index = hashFunction(key);
        table[index].Remove(key);
    }

    // Displays the hash table
    public void displayHash()
    {
        for (int i = 0; i < BUCKET; i++)
        {
            Console.Write(i + " --> ");
            foreach (int x in table[i])
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Array that contains keys to be mapped
        int[] a = { 15, 11, 27, 8, 12 };
        int n = a.Length;

        // Insert the keys into the hash table
        Hash h = new Hash(7); // 7 is the count of buckets in the hash table
        for (int i = 0; i < n; i++)
            h.insertItem(a[i]);

        // Delete 12 from the hash table
        h.deleteItem(12);

        // Display the hash table
        h.displayHash();
    }
}
