// C# Next Greatest Letter implementation in 
// Leetcode Link: https://leetcode.com/problems/find-smallest-letter-greater-than-target/
// Time Complexity: O(log n)
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0;
        int right = letters.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (letters[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return letters[left % letters.Length];
    }
}