// Concepts --> Array 
// C# Program to move all zeros in an array to the end while maintaining the relative order of non-zero elements.
// Leetcode Link --> https://leetcode.com/problems/move-zeroes/
// Time Complexity --> O(n)
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int writeIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[writeIndex++] = nums[i];
            }
        }
        while (writeIndex < nums.Length)
        {
            nums[writeIndex++] = 0;
        }
    }
}