// Concept --> Cyclic Sort
// C# Program to find the duplicate and missing number in an array
// Leetcode Problem Link --> https://leetcode.com/problems/set-mismatch/description/
// Time Complexity --> O(n)
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return new int[] { nums[i], i + 1 };
            }
        }
        return new int[] { -1, -1 };
    }
    public void Sort(int[] arr)
    {
        int i = 0;
        while (i < arr.Length)
        {
            int correctPos = arr[i] - 1;
            if (arr[i] != arr[correctPos])
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