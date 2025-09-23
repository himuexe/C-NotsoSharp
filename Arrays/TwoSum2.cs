// Concepts --> Two Pointers
// C# implementation of the solution for the problem "Two Sum II - Input Array Is Sorted"
// Leetcode Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
// Time Complexity: O(n)
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] == target) return new int[] { left + 1, right + 1 };
            else if (numbers[left] + numbers[right] < target) left++;
            else right--;
        }
        return new int[] { -1, -1 };
    }
}