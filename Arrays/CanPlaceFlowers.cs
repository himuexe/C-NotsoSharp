// Concepts --> Array, Greedy
// C# Program to determine if n new flowers can be planted in a flowerbed without violating the no-adjacent-flowers rule.
// Leetcode Link --> https://leetcode.com/problems/can-place-flowers/
// Time Complexity: O(m) where m is the length of the flowerbed array.
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                bool left = (i == 0) || (flowerbed[i - 1] == 0);
                bool right = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);
                if (left && right)
                {
                    flowerbed[i] = 1;
                    count++;
                    if (count >= n) return true;
                }
            }
        }
        return count >= n;
    }
}