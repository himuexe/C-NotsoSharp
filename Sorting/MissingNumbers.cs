// Concepts --> Cyclic Sort
// Program to find all the numbers that are missing from an array containing n numbers taken from the range 1 to n in C#
// Leetcode Link --> https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
// Time Complexity --> O(n)
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> list = new List<int>();
        Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1) list.Add(i + 1);
        }
        return list;
    }
    public void Sort(int[] nums)
    {
        int i = 0;
        while (i < nums.Length)
        {
            int cp = nums[i] - 1;
            if (nums[i] != nums[cp])
            {
                (nums[i], nums[cp]) = (nums[cp], nums[i]);
            }
            else i++;
        }
    }
}