// Insertion Sort Algorithm in C#
// Time Complexity: O(n^2) for worst and average cases, O(n) for best case
using System;
class Sorting
{
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
    public static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSort(arr);
        Console.WriteLine("Sorted array: ");
        PrintArray(arr);
    }
}