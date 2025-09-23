// Concepts --> Array, Depth-First Search (DFS)
// C# Program to determine if you can reach any index with value 0 in the array starting from a given index.
// Leetcode Link --> https://leetcode.com/problems/jump-game-iii/
// Time Complexity: O(n) where n is the length of the arr array.
public class Solution
{
    public bool CanReach(int[] arr, int start)
    {
        if (start < 0 || start >= arr.Length || arr[start] < 0) return false;
        if (arr[start] == 0) return true;
        arr[start] = -1 * arr[start];
        bool left = CanReach(arr, start + arr[start]);
        bool right = CanReach(arr, start - arr[start]);
        return left || right;
    }
}