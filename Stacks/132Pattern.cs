// C# to find if there is 132 pattern in array
// Leetcode link --> https://leetcode.com/problems/132-pattern/description/
public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if (nums.Length < 3) return false;

        int[] min = new int[nums.Length];
        min[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            min[i] = Math.Min(nums[i], min[i - 1]);
        }

        Stack<int> st = new Stack<int>();

        for (int i = nums.Length - 1; i >= 1; i--)
        {
            if (nums[i] > min[i])
            {
                while ((st.Count != 0) && (st.Peek() <= min[i]))
                {
                    st.Pop();
                }
                if (st.Count != 0 && st.Peek() < nums[i])
                {
                    return true;
                }
                st.Push(nums[i]);
            }
        }
        return false;
    }
}