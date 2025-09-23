// Concept --> Cyclic Sort
// C# implementation to find the first missing positive integer in an array
// Leetcode Problem Link: https://leetcode.com/problems/first-missing-positive/
// Time Complexity: O(n)
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1) return i + 1;
        }
        return nums.Length + 1;
    }
    public void Sort(int[] arr)
    {
        int i = 0;
        while (i < arr.Length)
        {
            int correctPos = arr[i] - 1;
            if (arr[i] > 0 && arr[i] <= arr.Length && arr[i] != arr[correctPos])
            {
                (arr[i], arr[correctPos]) = (arr[correctPos], arr[i]);
            }
            else
            {
                i++;
            }
        }
    }
}