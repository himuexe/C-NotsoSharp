// Concepts --> Arrays, Two Pointers, Rotated Array
// C# implementation to check if a pair with a given sum exists in a sorted and rotated array
// Time Complexity: O(n)
class PairSumRotated
{
    static bool HasPairWithSum(int[] arr, int sum)
    {
        if (arr == null || arr.Length < 2)
            return false;

        int n = arr.Length;
        int pivot = FindPivot(arr);
        int left = (pivot + 1) % n;
        int right = pivot;

        while (left != right)
        {
            int currentSum = arr[left] + arr[right];

            if (currentSum == sum)
                return true;

            if (currentSum < sum)
                left = (left + 1) % n;
            else
                right = (n + right - 1) % n;
        }

        return false;
    }

    static int FindPivot(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                return i;
        }
        return n - 1;
    }

    static void Main()
    {
        int[] arr = [11, 15, 6, 8, 9, 10];
        int sum = 16;
        Console.WriteLine(HasPairWithSum(arr, sum));
    }
}