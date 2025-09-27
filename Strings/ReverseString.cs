// Reverse a string 
public class Solution
{
    public static string ReverseString(string s) 
    {
        StringBuilder result = new StringBuilder();
        for(int i = s.Length - 1; i >= 0; i--)
        {
            result.Append(s[i]);
        }
        return result.ToString();
    }
    
    public static void Main(string[] args)
    {
        string s = "himanshu";
        Console.WriteLine(ReverseString(s));
    }
}