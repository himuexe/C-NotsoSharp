// Concepts --> Loops, Arrays, Math
// C# Program to print all prime numbers in a given range using the Sieve of Eratosthenes
// Time Complexity: O(n log log n)

class PrimesInRange
{
    static void Main()
    {
        Console.Write("Enter upper bound: ");
        int upper = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers up to {upper}:");
        PrintPrimesSieve(upper);
    }

    static void PrintPrimesSieve(int n)
    {
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
            isPrime[i] = true;

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                    isPrime[i] = false;
            }
        }

        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
                Console.Write(i + " ");
        }
    }
}