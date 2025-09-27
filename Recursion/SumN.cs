class Solution
{
    public static int SumN(int n)
    {
        if (n == 1) return 1;
        return n + SumN(n - 1);
    }
}