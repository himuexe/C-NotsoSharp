class Solution
{
    public static bool IsSorted(int[] arr, int i)
    {
        if (i == arr.Length - 1) return true;
        if (arr[i] > arr[i + 1]) return false;
        return IsSorted(arr, i + 1);
    }
}