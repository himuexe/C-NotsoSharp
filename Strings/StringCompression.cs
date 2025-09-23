// Compress a string by replacing consecutive identical characters with the character followed by the count of repetitions
// Leetcode Link: https://leetcode.com/problems/string-compression/
// Time Complexity: O(n) where n is the length of the string
public class Solution
{
    public string CompressedString(string word)
    {
        StringBuilder newStr = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            int count = 1;
            while (i < word.Length - 1 && word[i] == word[i + 1])
            {
                i++;
                count++;
                if (count >= 9) break;
            }
            newStr.Append(count.ToString());
            newStr.Append(word[i]);
        }
        return newStr.ToString();
    }
}