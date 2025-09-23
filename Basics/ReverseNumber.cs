// Concepts --> Loops, Math
// C# Program to reverse a number
// Time Complexity: O(d) where d is the number of digits in the number
class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to reverse: ");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = 0;
        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        Console.WriteLine("Reversed number: " + reversedNumber);
    }
}