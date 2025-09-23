// Concepts --> Array, Two Pointers
// C# Program to find the maximum area of water that can be contained between two lines in an array.
// Leetcode Link --> https://leetcode.com/problems/container-with-most-water/
// Time Complexity: O(n) where n is the length of the height array.
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, maxArea = 0;
        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            maxArea = Math.Max(maxArea, h * w);
            if (height[left] < height[right]) left++;
            else right--;
        }
        return maxArea;
    }
}