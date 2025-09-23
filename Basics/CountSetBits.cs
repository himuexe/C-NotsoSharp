// Concepts --> Bit Manipulation, Loops
// C# Program to count the number of set bits (1s) in the binary representation
// Time Complexity: O(b) where b is the number of bits in the integer
class CountSetBits
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        while (number != 0)
        {
            count += number & 1;
            number >>= 1;
        }
        Console.WriteLine("Number of set bits: " + count);
    }
}