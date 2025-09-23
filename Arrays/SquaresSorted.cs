// Concepts --> Two Pointers, Array
// C# Program to return an array of the squares of each number sorted in non-decreasing order.
// LeetCode Problem Link --> https://leetcode.com/problems/squares-of-a-sorted-array
// Time Complexity --> O(n)
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int left = 0, right = n - 1, p = n - 1;
        int[] squares = new int[n];
        while (left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];
            if (leftSquare > rightSquare)
            {
                squares[p--] = leftSquare;
                left++;
            }
            else
            {
                squares[p--] = rightSquare;
                right--;
            }
        }
        return squares;
    }
}