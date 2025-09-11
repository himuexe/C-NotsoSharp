using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }
}