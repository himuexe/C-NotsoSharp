// Concepts --> Greedy Algorithm , Largest Difference
// C# Program to find the maximum profit from a single buy-sell transaction of stock prices given in an array.
// Leetcode Link --> https://leetcode.com/problems/best-time-to-buy-and-sell-stock
// Time Complexity --> O(n)
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0, minPrice = prices[0];
        foreach (int price in prices)
        {
            if (price < minPrice) minPrice = price;
            else if (price - minPrice > maxProfit) maxProfit = price - minPrice;
        }
        return maxProfit;
    }
}