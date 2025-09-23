// Concepts --> Loops, Math
// C# Program to check if a number is prime
// Time Complexity: O(√n)
class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1) isPrime = false;
        if (number == 2) isPrime = true;
        if (number > 2 && number % 2 == 0) isPrime = false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("The number is prime.");
        }
        else
        {
            Console.WriteLine("The number is not prime.");
        }
    }
}