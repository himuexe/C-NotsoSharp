// C# program to find Longest Valid Parentheses
// Leetcode Link --> https://leetcode.com/problems/longest-valid-parentheses/description/
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int ans = 0;
        Stack<int> st = new Stack<int>();
        st.Push(-1);
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch == '(')
            {
                st.Push(i);
            }
            else
            {
                st.Pop();
                if (st.Count == 0)
                {
                    st.Push(i);
                }
                else
                {
                    ans = Math.Max(ans, i - st.Peek());
                }
            }
        }
        return ans;
    }
}