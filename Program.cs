using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10, 12 };

        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        // Linear Search
        int linearResult = LinearSearch.Search(arr, target);

        if (linearResult != -1)
            Console.WriteLine("Linear Search: Found at index " + linearResult);
        else
            Console.WriteLine("Linear Search: Not Found");

        // Binary Search
        int binaryResult = BinarySearch.Search(arr, target);

        if (binaryResult != -1)
            Console.WriteLine("Binary Search: Found at index " + binaryResult);
        else
            Console.WriteLine("Binary Search: Not Found");
    }
}