// Concepts --> Math, Loops
// C# Program to check if a number is an Armstrong number
// Time Complexity: O(d) where d is the number of digits in the number
class Armstrong
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's an Armstrong number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;
        int digits = (int)Math.Log10(number) + 1;
        while (number != 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digits);
            number /= 10;
        }
        if (sum == originalNumber)
        {
            Console.WriteLine("The number is an Armstrong number.");
        }
        else
        {
            Console.WriteLine("The number is not an Armstrong number.");
        }
    }
}