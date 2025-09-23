// C# Search a 2D Matrix implementation in C#
 // Leetcode Link: https://leetcode.com/problems/search-a-2d-matrix/
 // Time Complexity: O(m + n)
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0, col = matrix[0].Length - 1;
        while (row < matrix.Length && col >= 0)
        {
            if (matrix[row][col] == target) return true;
            else if (matrix[row][col] < target) row++;
            else col--;
        }
        return false;
    }
}