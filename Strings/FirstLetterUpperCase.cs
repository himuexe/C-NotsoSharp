using System;
using System.Text;

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