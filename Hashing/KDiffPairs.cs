using System;
using System.Collections.Generic;

public class Solution {
    public int FindPairs(int[] nums, int k) {
        if(k < 0) return 0; // k cannot be negative
        
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach(int num in nums) {
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;
        }
        
        int count = 0;
        foreach(var (number, freq) in frequencyMap) {
            if(k == 0) {
                // Count numbers that appear at least twice
                if(freq >= 2) {
                    count++;
                }
            }
            else {
                // Check if (number + k) exists in the map
                if(frequencyMap.ContainsKey(number + k)) {
                    count++;
                }
            }
        }
        return count;
    }
}