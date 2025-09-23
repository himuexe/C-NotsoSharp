// Concepts --> Factorials, Loops
// C# Program to calculate the Binomial Coefficient C(n, r)
// Time Complexity: O(n) due to the factorial calculations
class BinomialCoefficient
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter r : ");
        int r = int.Parse(Console.ReadLine());
        if (r > n || n < 0 || r < 0)
        {
            Console.WriteLine("Invalid input. Ensure that 0 <= r <= n.");
            return;
        }
        int binomialCoefficient = Factorial(n) / (Factorial(r) * Factorial(n - r));
        Console.WriteLine($"Binomial Coefficient C({n}, {r}) = {binomialCoefficient}");
    }
}