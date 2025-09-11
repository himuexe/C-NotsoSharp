using System;
class LCM
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers to find their LCM: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("LCM of {0} and {1} is: {2}", a, b, FindLCM(a, b));
    }

    static int FindLCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
}