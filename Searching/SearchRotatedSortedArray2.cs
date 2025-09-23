// C# Search in Rotated Sorted Array II implementation in C#
 // Leetcode Link: https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
 // Time Complexity: O(log n) on average, O(n) in the worst case
public class Solution
{
    public bool Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return true;
            else if (nums[mid] == nums[left] && nums[mid] == nums[right])
            {
                left++;
                right--;
            }
            else if (nums[left] <= nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return false;
    }
}