// Selection Sort Algorithm in C#
// Time Complexity: O(n^2) for all cases
using System;
class Sorting
{
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            (arr[i], arr[min_idx]) = (arr[min_idx], arr[i]);
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
        int[] arr = { 64, 25, 12, 22, 11 };
        SelectionSort(arr);
        Console.WriteLine("Sorted array: ");
        PrintArray(arr);
    }
}