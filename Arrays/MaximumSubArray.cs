// Concepts --> Array , Kadane's Algorithm
// C# Program to find the contiguous subarray with the largest sum.
// Leetcode Link --> https://leetcode.com/problems/maximum-subarray/
// Time Complexity --> O(n)
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxCurrent = nums[0], maxGlobal = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            maxCurrent = Math.Max(nums[i], maxCurrent + nums[i]);
            maxGlobal = Math.Max(maxCurrent, maxGlobal);
        }
        return maxGlobal;
    }
}