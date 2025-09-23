// Check if string s is a subsequence of string t
// Leetcode Link: https://leetcode.com/problems/is-subsequence/
// Time Complexity: O(n)
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int p1 = 0, p2 = 0;
        while (p1 < s.Length && p2 < t.Length)
        {
            if (s[p1] == t[p2])
            {
                p1++;
                p2++;
            }
            else
            {
                p2++;
            }
        }
        return p1 == s.Length;
    }
}