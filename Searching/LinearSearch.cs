// C# Linear Search implementation in C#
 // Time Complexity: O(n)
 
class LinearSearch
{
    int Search(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
}