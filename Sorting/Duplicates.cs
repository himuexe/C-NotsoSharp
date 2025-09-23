// Concept --> Cyclic Sort
// C# implementation to find all duplicates in an array
// Leetcode Problem Link: https://leetcode.com/problems/find-all-duplicates-in-an-array/
// Time Complexity: O(n)
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> list = new List<int>();
        Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                list.Add(nums[i]);
                while (i + 1 < nums.Length && nums[i] == nums[i + 1]) i++;
            }
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
                (nums[i], nums[cp]) = (nums[cp], nums[i]);
            else i++;
        }
    }
}