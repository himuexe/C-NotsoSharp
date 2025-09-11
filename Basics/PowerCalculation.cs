using System;
class PowerCalculation
{
    static void Main()
    {
        Console.WriteLine("Enter the base number: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {CalculatePower(baseNumber, exponent)}");
    }
    static double CalculatePower(double baseNum, double exp)
    {
        double result = 1;
        long positiveExp = (long)Math.Abs(exp);
        while (positiveExp > 0)
        {
            if (positiveExp % 2 == 0)
            {
                baseNum *= baseNum;
                positiveExp /= 2;
            }
            else
            {
                result *= baseNum;
                positiveExp--;
            }
        }
        return exp < 0 ? 1 / result : result;
    }
}