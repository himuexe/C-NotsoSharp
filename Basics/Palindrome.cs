// Concepts --> Loops, Math
// C# Program to check if a number is a palindrome
// Time Complexity: O(d) where d is the number of digits in the number
class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's a palindrome:");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int reversedNumber = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }
        if (originalNumber == reversedNumber)
        {
            Console.WriteLine("{0} is a palindrome.", originalNumber);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome.", originalNumber);
        }
    }
}