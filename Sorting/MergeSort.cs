// Merge Sort Algorithm in C#
// Time Complexity: O(n log n)

using System;
class Sorting
{
    public static void MergeSort(int[] array, int left, int right)
    {
        if (left >= right)
            return;
        int mid = left + (right - left) / 2;
        MergeSort(array, left, mid);
        MergeSort(array, mid + 1, right);
        Merge(array, left, mid, right);
    }
    public static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
        }
        while (i <= mid)
            temp[k++] = arr[i++];
        while (j <= right)
            temp[k++] = arr[j++];
        Array.Copy(temp, 0, arr, left, temp.Length);
    }
    public static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original Array: " + string.Join(", ", array));
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}