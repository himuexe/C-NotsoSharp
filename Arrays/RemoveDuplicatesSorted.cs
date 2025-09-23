// Concepts --> Arrays
// C# implementation to remove duplicates from a sorted array in-place
// Leetcode Link --> https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// Time Complexity: O(n)
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int writeIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1]) nums[writeIndex++] = nums[i];
        }
        return writeIndex;
    }
}