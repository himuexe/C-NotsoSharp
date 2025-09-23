// Concepts --> Nested Loops
// C# Program to find the richest customer wealth
// Leetcode Problem Link --> https://leetcode.com/problems/richest-customer-wealth/
// Time Complexity --> O(N*M) where N is number of customers and M is number of accounts per customer
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int currentWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                currentWealth += accounts[i][j];
            }
            maxWealth = Math.Max(maxWealth, currentWealth);
        }
        return maxWealth;
    }
}