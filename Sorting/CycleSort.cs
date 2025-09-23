// Cycle Sort implementation in C#
// Time Complexity: O(n^2) in the worst case
using System;
class Sorting
{
    public static void CycleSort(int[] arr)
    {
        int i = 0;
        while (i < arr.Length)
        {
            int correctIndex = arr[i] - 1;
            if (arr[i] != arr[correctIndex])
            {
                (arr[correctIndex], arr[i]) = (arr[i], arr[correctIndex]);
            }
            else
            {
                i++;
            }
        }
    }
}