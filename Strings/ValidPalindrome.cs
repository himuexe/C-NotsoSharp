// Check if a given string is a valid palindrome, considering only alphanumeric characters and ignoring cases
// Leetcode Link: https://leetcode.com/problems/valid-palindrome/
// Time Complexity: O(n) where n is the length of the string
class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++;
            while (left < right && !char.IsLetterOrDigit(s[right])) right--;
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}