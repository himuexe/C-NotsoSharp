using System;
class HammingDistance
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers to find their Hamming Distance: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Hamming Distance between {0} and {1} is: {2}", a, b, FindHammingDistance(a, b));
    }

    static int FindHammingDistance(int a, int b)
    {
        int xor = a ^ b;
        int distance = 0;
        while (xor != 0)
        {
            distance += xor & 1;
            xor >>= 1;
        }
        return distance;
    }
}