// C# program to check for duplicate parentheses in an expression
// Time Complexity: O(n)

using System;
using System.Collections.Generic;
class Solution
{
    static bool FindDuplicateParentheses(string str)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in str)
        {
            if (ch == ')')
            {
                int count = 0;
                while (stack.Peek() != '(' && stack.Count != 0)
                {
                    stack.Pop();
                    count++;
                }
                if (count < 1)
                    return true;
                else
                    stack.Pop();
            }
            else
            {
                stack.Push(ch);
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        string str = "(a+b)+((c+d))";
        if (FindDuplicateParentheses(str))
            Console.WriteLine("Duplicate parentheses found");
        else
            Console.WriteLine("No duplicate parentheses found");
    }

}