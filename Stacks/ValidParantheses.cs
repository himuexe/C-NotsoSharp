// C# to find if the given string has a valid parentheses 
// Leetcode Link --> https://leetcode.com/problems/valid-parentheses/
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> st = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '{' || ch == '[' || ch == '(')
            {
                st.Push(ch);
            }
            else
            {
                if (st.Count == 0)
                {
                    return false;
                }
                if ((st.Peek() == '(' && ch == ')') ||
                   (st.Peek() == '{' && ch == '}') ||
                   (st.Peek() == '[' && ch == ']'))
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}