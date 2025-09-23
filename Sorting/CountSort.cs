// Counting Sort Algorithm in C#
// Time Complexity: O(n + k) where n is the number of elements in input array and k is the range of input
using System;
class Sorting
{
    public static void CountSort(int[] arr)
    {
        int n = arr.Length;
        if (n == 0) return;
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        int[] count = new int[max + 1];
        for (int i = 0; i < n; i++)
        {
            count[arr[i]]++;
        }
        int j = 0;
        for (int i = 0; i <= max; i++)
        {
            while (count[i] > 0)
            {
                arr[j++] = i;
                count[i]--;
            }
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
        int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
        CountSort(arr);
        Console.WriteLine("Sorted array: ");
        PrintArray(arr);
    }
}