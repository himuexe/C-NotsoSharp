// Find the longest common prefix string amongst an array of strings
// Leetcode Link: https://leetcode.com/problems/longest-common-prefix/
// Time Complexity: O(n*m) where n is the number of strings and m is the length of the shortest string
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                {
                    return "";
                }
            }
        }
        return prefix;
    }
}