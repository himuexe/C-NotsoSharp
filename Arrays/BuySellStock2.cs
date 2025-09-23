// Concepts --> Greedy Algorithm , Local Minima and Maxima
// C# Program to find the maximum profit from multiple buy-sell transactions of stock prices given in an array.
// Leetcode Link --> https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
// Time Complexity --> O(n)
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1]) maxProfit += prices[i] - prices[i - 1];
        }
        return maxProfit;
    }
}