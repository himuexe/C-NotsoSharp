// C# program to find the next greater element for each element in an array
// Time Complexity: O(n)
using System;
using System.Collections.Generic;

class Solution
{
    public static int[] Next(int[] nums)
    {
        int[] result = new int[nums.Length];
        Stack<int> st = new Stack<int>();
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            // Pop elements from stack while they are smaller than or equal to current element
            while(st.Count > 0 && nums[st.Peek()] <= nums[i])
            {
                st.Pop();
            }
            
            // If stack is empty, no greater element exists
            if(st.Count == 0)
            {
                result[i] = -1;
            }
            else 
            {
                result[i] = nums[st.Peek()];
            }
            
            st.Push(i);
        }
        return result;
    }
    
    static void Main(string[] args)
    {
        // Test cases
        int[] test1 = {4, 5, 2, 25};
        int[] test2 = {13, 7, 6, 12};
        int[] test3 = {1, 2, 3, 4, 5};
        int[] test4 = {5, 4, 3, 2, 1};
        
        Console.WriteLine("Next Greater Elements:");
        
        Console.Write("Input: [4, 5, 2, 25] -> ");
        Console.WriteLine("Output: [" + string.Join(", ", Next(test1)) + "]");
        
        Console.Write("Input: [13, 7, 6, 12] -> ");
        Console.WriteLine("Output: [" + string.Join(", ", Next(test2)) + "]");
        
        Console.Write("Input: [1, 2, 3, 4, 5] -> ");
        Console.WriteLine("Output: [" + string.Join(", ", Next(test3)) + "]");
        
        Console.Write("Input: [5, 4, 3, 2, 1] -> ");
        Console.WriteLine("Output: [" + string.Join(", ", Next(test4)) + "]");
    }
}