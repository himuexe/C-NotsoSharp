// Concepts --> Bit Manipulation
// C# Program to find the single number in an array where every element appears twice except for one.
// LeetCode Problem Link --> https://leetcode.com/problems/single-number/
// Time Complexity --> O(n)
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ans = 0;
        foreach (int num in nums)
        {
            ans ^= num;
        }
        return ans;
    }
}