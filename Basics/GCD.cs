using System;
class GCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers to find their GCD: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD of {0} and {1} is: {2}", a, b, FindGCD(a, b));
    }

    static int FindGCD(int a, int b)
    {
        if(a==0)
        {
            return b;
        }
        return FindGCD(b % a, a);
    }
}