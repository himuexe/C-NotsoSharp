// Concept --> Quickselect algorithm to find the kth largest element in an array
// C# implementation to find the kth largest element using Quickselect.
// Leetcode Problem Link: https://leetcode.com/problems/kth-largest-element-in-an-array/
// Time Complexity: O(n) on average, O(n^2) in the worst case

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // Convert kth largest to 0-based index
        return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
    }

    private int QuickSelect(int[] nums, int low, int high, int k)
    {
        int pi = Partition(nums, low, high);

        if (pi == k)
        {
            return nums[pi];  // Found kth largest element
        }
        else if (pi < k)
        {
            return QuickSelect(nums, pi + 1, high, k);  // Search right
        }
        else
        {
            return QuickSelect(nums, low, pi - 1, k);   // Search left
        }
    }

    private int Partition(int[] nums, int low, int high)
    {
        int pivot = nums[high];  // Last element as pivot
        int i = low - 1;         // Partition index

        // Lomuto partition scheme
        for (int j = low; j < high; j++)
        {
            if (nums[j] <= pivot)
            {
                i++;
                // Swap using tuple deconstruction
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        // Swap using tuple deconstruction
        (nums[i + 1], nums[high]) = (nums[high], nums[i + 1]);
        return i + 1;  // Return pivot index
    }
}