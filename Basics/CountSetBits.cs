using System;
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