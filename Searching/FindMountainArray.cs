// C# Find in Mountain Array implementation in C#
// Leetcode Link: https://leetcode.com/problems/find-in-mountain-array/
// Time Complexity: O(log n)
/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution
{
    public int FindInMountainArray(int target, MountainArray mountainArr)
    {
        int peak = findPivot(mountainArr);
        int asc = binarySearch(mountainArr, 0, peak, target, true);
        if (asc != -1) return asc;
        return binarySearch(mountainArr, peak + 1, mountainArr.Length() - 1, target, false);
    }
    private int findPivot(MountainArray arr)
    {
        int left = 0, right = arr.Length() - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr.Get(mid) > arr.Get(mid + 1)) right = mid;
            else left = mid + 1;
        }
        return left;
    }
    private int binarySearch(MountainArray arr, int left, int right, int target, bool asc)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midVal = arr.Get(mid);
            if (midVal == target) return mid;
            if (asc)
            {
                if (midVal < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            else
            {
                if (midVal < target)
                {
                    right = mid - 1;
                }
                else left = mid + 1;
            }
        }
        return -1;
    }
}