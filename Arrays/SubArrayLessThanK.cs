// Concepts --> Two Pointers
// C# implementation of the solution for the problem "Subarray Product Less Than K"
// Leetcode Link: https://leetcode.com/problems/subarray-product-less-than-k/
// Time Complexity: O(n)
public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1) return 0;
        int left = 0, product = 1, count = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            product *= nums[right];
            while (product >= k)
            {
                product /= nums[left++];
            }
            count += right - left + 1;
        }
        return count;
    }
}