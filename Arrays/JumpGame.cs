// Concepts --> Array, Greedy
// C# Program to determine if you can reach the last index of the array given that each element represents the maximum jump length at that position.
// Leetcode Link --> https://leetcode.com/problems/jump-game/
// Time Complexity: O(n) where n is the length of the nums array.
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxReachable = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReachable) return false;
            maxReachable = Math.Max(maxReachable, i + nums[i]);
            if (maxReachable >= nums.Length - 1) return true;
        }
        return true;
    }
}