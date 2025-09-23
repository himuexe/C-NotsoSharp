// C# Nth Root implementation in C#
 // Time Complexity: O(log n * k) where k is the power value
public class Solution
{
    public long Search(int number, int power)
    {
        if (power == 1)
        {
            return number;
        }
        if (number == 0 || number == 1)
        {
            return number;
        }

        long left = 0;
        long right = number;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long midPower = Power(mid, power);

            if (midPower == number)
            {
                return mid;
            }
            else if (midPower < number)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    private long Power(long baseNum, int exp)
    {
        long result = 1;
        for (int i = 0; i < exp; i++)
        {
            if (result > long.MaxValue / baseNum)
            {
                return long.MaxValue;
            }
            result *= baseNum;
        }
        return result;
    }
}