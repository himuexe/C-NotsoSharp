// Concepts --> Loops, Math
// C# Program to convert a binary number to its decimal equivalent
// Time Complexity: O(d) where d is the number of digits in the binary number
class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        int binaryNumber = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        int pow = 0;
        while (binaryNumber != 0)
        {
            decimalNumber += (binaryNumber % 10) * (int)Math.Pow(2, pow);
            pow++;
            binaryNumber /= 10;
        }
        Console.WriteLine("Decimal equivalent: " + decimalNumber);
    }
}