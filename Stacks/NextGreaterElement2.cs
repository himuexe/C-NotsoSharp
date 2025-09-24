// C# program to find the next greater element for each element in a circular array
// Leetcode Problem: https://leetcode.com/problems/next-greater-element-ii/
// Time Complexity: O(n)
public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        // Initialize result array with -1
        for (int i = 0; i < n; i++)
        {
            result[i] = -1;
        }

        // Process the array twice to handle circular nature
        for (int i = 0; i < 2 * n; i++)
        {
            int idx = i % n; // Wrap around using modulo

            while (stack.Count > 0 && nums[stack.Peek()] < nums[idx])
            {
                int popped = stack.Pop();
                result[popped] = nums[idx];
            }

            // Only push indices during the first pass
            if (i < n)
            {
                stack.Push(idx);
            }
        }

        return result;
    }
}