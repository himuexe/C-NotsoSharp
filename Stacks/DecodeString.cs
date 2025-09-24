// C# program to Decode String using Stack
// Leetcode Link --> https://leetcode.com/problems/decode-string/description/

public class Solution
{
    public string DecodeString(string s)
    {
        Stack<int> numStack = new Stack<int>();
        Stack<string> strStack = new Stack<string>();
        StringBuilder curr = new StringBuilder();
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            char ch = s[i];
            if (char.IsDigit(ch))
            {
                int num = ch - '0';
                while (i + 1 < n && char.IsDigit(s[i + 1]))
                {
                    num = num * 10 + (s[i + 1] - '0');
                    i++;
                }
                numStack.Push(num);
            }
            else if (ch == '[')
            {
                strStack.Push(curr.ToString());
                curr = new StringBuilder();
            }
            else if (ch == ']')
            {
                int k = numStack.Pop();
                StringBuilder temp = new StringBuilder(strStack.Pop());
                for (int j = 0; j < k; j++) temp.Append(curr);
                curr = temp;
            }
            else
            {
                curr.Append(ch);
            }
        }
        return curr.ToString();
    }
}