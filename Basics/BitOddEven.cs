// Concepts --> Bitwise Operations
// C# Program to determine if a number is odd or even using bitwise operations
// Time Complexity: O(1)
class BitOddEven
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = (number & 1) == 1;
        if (isOdd)
        {
            Console.WriteLine("The number is odd.");
        }
        else
        {
            Console.WriteLine("The number is even.");
        }
    }
}