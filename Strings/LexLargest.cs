// Find the lexicographically largest string in an array of strings
// Leetcode Link: https://leetcode.com/problems/lexicographically-largest-string/
// Time Complexity: O(n*m) where n is the number of strings and m is the average length of the strings
static string GetLargest(string[] str)
{
    string largest = str[0];
    for (int i = 1; i < str.Length; i++)
    {
        if (largest.CompareTo(str[i]) < 0)
        {
            largest = str[i];
        }
    }
    return largest;
    //
    // return str.Max(); // Using LINQ
}