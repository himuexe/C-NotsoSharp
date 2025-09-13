using System;
class StringCompression
{
    public static string CompressionString(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            int count = 1;
            while (i < str.Length - 1 && str[i] == str[i + 1])
            {
                count++;
                i++;
            }
            result += str[i];
            if (count > 1)
                result += count.ToString();
        }

        return result;
    }
}