// C# program to solve Stock Spanner Problem 
// Leetcode link --> https://leetcode.com/problems/online-stock-span/
public class StockSpanner
{
    private Stack<(int price, int span)> stack;

    public StockSpanner()
    {
        stack = new Stack<(int, int)>();
    }

    public int Next(int price)
    {
        int span = 1;
        while (stack.Count > 0 && stack.Peek().price <= price)
        {
            span += stack.Pop().span;
        }
        stack.Push((price, span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */