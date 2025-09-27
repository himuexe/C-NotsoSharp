class Solution
{
    public static int FirstOccurance(int[] arr, int key, int i)
    {
        if (i == arr.Length - 1) return -1;
        if (arr[i] == key) return i;
        return FirstOccurance(arr, key, i + 1);
    }
    public static int LastOccurance(int[] arr, int key, int i)
    {
        if (i == arr.Length - 1) return -1;
        int isFound = LastOccurance(arr, key, i + 1);
        if (isFound == -1 && arr[i] == key) return i;
        return isFound;
    }
}