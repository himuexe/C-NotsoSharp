class Solution
{
    public static int Ways(int n)
    {
        if (n <= 1) return 1;
        return Ways(n - 1) + Ways(n - 2);
    }
}