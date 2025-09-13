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