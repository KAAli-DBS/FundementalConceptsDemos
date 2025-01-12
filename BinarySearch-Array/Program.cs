using System;

class BinarySearchExample
{
    
    public static int BinarySearch(int[] arr, int target)
    {
        // Start index
        int low = 0; 
        // End index
        int high = arr.Length - 1; 

        while (low <= high)
        {
            // Find the middle index
            int mid = low + (high - low) / 2; 

            // Check if the target is present at the middle index
            if (arr[mid] == target)
            {
                return mid; 
            }

            // If target is smaller than mid value, search in the left half
            else if (arr[mid] > target)
            {
                high = mid - 1;
            }
            // If target is larger than mid value, search in the right half
            else
            {
                low = mid + 1;
            }
        }

        return -1; // Target not found
    }

    static void Main(string[] args)
    {
       
        int[] arr = { 11, 31, 53, 76, 94, 110, 134, 165, 174, 197 };

        int target = 76;

      
        int result = BinarySearch(arr, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
    }
}