class Solution
{
    public static void PrintDesc(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }
        Console.WriteLine(n);
        PrintDesc(n - 1);
    }
    public static void PrintAsc(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }
        PrintAsc(n-1);
        Console.WriteLine(n);
    }
}