class Solution
{
    public static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;
    
    Dictionary<char, int> count = new Dictionary<char, int>();
    
    foreach (char c in s)
    {
        count[c] = count.GetValueOrDefault(c, 0) + 1;
    }
    
    foreach (char c in t)
    {
        if (!count.TryGetValue(c, out int currentCount) || currentCount == 0)
            return false;
        
        count[c] = currentCount - 1;
    }
    
    return true;
}
}