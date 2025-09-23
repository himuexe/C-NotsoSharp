// Concepts --> Two Pointers
// C# Program to reverse an array in place
// Leetcode Problem Link --> https://leetcode.com/problems/reverse-string/
// Time Complexity --> O(N)
public class Solution {
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char temp = s[right];
            s[right--] = s[left];
            s[left++] = temp;
        }
    }
}