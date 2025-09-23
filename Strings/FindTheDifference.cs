// Find the difference between two strings where one string is an anagram of the other plus one extra character
// Leetcode Link: https://leetcode.com/problems/find-the-difference/
// Time Complexity: O(n)
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char result = '\0';
        for (int i = 0; i < s.Length; i++) result ^= s[i];
        for (int i = 0; i < t.Length; i++) result ^= t[i];
        return result;
    }
}