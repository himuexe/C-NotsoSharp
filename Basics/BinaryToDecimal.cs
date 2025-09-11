using System;
class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        int binaryNumber = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        int baseValue = 1;
        while (binaryNumber > 0)
        {
            int lastDigit = binaryNumber % 10;
            decimalNumber += lastDigit * baseValue;
            baseValue *= 2;
            binaryNumber /= 10;
        }
        Console.WriteLine("Decimal equivalent: " + decimalNumber);
    }
}