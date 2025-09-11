using System;
class Armstrong
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's an Armstrong number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;
        int digits = number.ToString().Length;
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