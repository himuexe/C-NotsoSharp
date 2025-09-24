// C# program to find the largest rectangle in histogram
// Leetcode Problem: https://leetcode.com/problems/largest-rectangle-in-histogram/
// Time Complexity: O(n)
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        Stack<int> st = new Stack<int>();
        int[] nsr = new int[heights.Length];
        int[] nsl = new int[heights.Length];

        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && heights[st.Peek()] >= heights[i])
            {
                st.Pop();
            }
            if (st.Count == 0)
            {
                nsr[i] = heights.Length;
            }
            else nsr[i] = st.Peek();
            st.Push(i);
        }

        st = new Stack<int>();

        for (int i = 0; i < heights.Length; i++)
        {
            while (st.Count > 0 && heights[st.Peek()] >= heights[i])
            {
                st.Pop();
            }
            if (st.Count == 0)
            {
                nsl[i] = -1;
            }
            else nsl[i] = st.Peek();
            st.Push(i);
        }

        for (int i = 0; i < heights.Length; i++)
        {
            int h = heights[i];
            int w = nsr[i] - nsl[i] - 1;
            maxArea = Math.Max(maxArea, h * w);
        }
        return maxArea;

    }
}