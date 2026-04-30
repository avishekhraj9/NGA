using System;

public class LinearSearch
{
    public static int Search(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // found
            }
        }
        return -1; // not found
    }
}