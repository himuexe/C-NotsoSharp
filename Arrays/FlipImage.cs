// Concepts --> Array, Two Pointers
// C# Program to flip and invert a binary image represented as a 2D array.
// Leetcode Link --> https://leetcode.com/problems/flipping-an-image/
// Time Complexity: O(n^2) where n is the number of rows (or columns) in the square image.
public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        for (int i = 0; i < image.Length; i++)
        {
            int left = 0, right = image.Length - 1;
            while (left <= right)
            {
                int temp = image[i][left];
                image[i][left] = 1 - image[i][right];
                image[i][right] = 1 - temp;
                left++;
                right--;
            }
        }
        return image;
    }
}