// Concepts --> Array , Matrix
// C# Program to find the sum of the matrix diagonals.
// Leetcode Link --> https://leetcode.com/problems/matrix-diagonal-sum/
// Time Complexity --> O(n)
public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
            sum += mat[i][mat.Length - i - 1];
        }
        if (mat.Length % 2 == 1)
        {
            sum -= mat[mat.Length / 2][mat.Length / 2];
        }
        return sum;
    }
}