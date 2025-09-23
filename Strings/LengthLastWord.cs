// Find the length of the last word in a string
// Leetcode Link: https://leetcode.com/problems/length-of-last-word/
// Time Complexity: O(n)
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int p = s.Length - 1, length = 0;
        while (p >= 0 && s[p] == ' ') p--;
        while (p >= 0 && s[p] != ' ')
        {
            length++;
            p--;
        }
        return length;
    }
}