// Concepts --> Array , Boyer-Moore Voting Algorithm
// C# Program to find the majority element in an array.
// Leetcode Link --> https://leetcode.com/problems/majority-element/
// Time Complexity --> O(n)
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = nums[0], count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
                count = 1;
            }
            else if (nums[i] == candidate) count++;
            else count--;
        }
        return candidate;
    }
}