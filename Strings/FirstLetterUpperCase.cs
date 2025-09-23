// Convert the first letter of each word in a string to uppercase
// Leetcode Link: https://leetcode.com/problems/capitalize-the-title/
// Time Complexity: O(n) where n is the length of the string

class FirstLetterUpperCase
{
    public static string ConvertFirstLetterToUpperCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        StringBuilder result = new StringBuilder();
        bool capitalizeNext = true;

        foreach (char c in str)
        {
            if (char.IsWhiteSpace(c))
            {
                result.Append(c);
                capitalizeNext = true;
            }
            else if (capitalizeNext)
            {
                result.Append(char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}