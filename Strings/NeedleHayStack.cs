// Implement strStr() function to find the first occurrence of a substring in a string
// Leetcode Link: https://leetcode.com/problems/implement-strstr/
// Time Complexity: O(m*n) where m is the length of haystack and n is the length of needle
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle)) return 0;
        int m = haystack.Length, n = needle.Length;
        if (n > m) return -1;
        for (int i = 0; i <= m - n; i++)
        {
            string str = haystack.Substring(i, n);
            if (str == needle) return i;
        }
        return -1;
    }
}