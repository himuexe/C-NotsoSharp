// Reverse a string in place
// Leetcode Link: https://leetcode.com/problems/reverse-string/
// Time Complexity: O(n) where n is the length of the string
public class Solution
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char temp = s[right];
            s[right] = s[left];
            s[left] = temp;
            left++;
            right--;
        }
    }
}