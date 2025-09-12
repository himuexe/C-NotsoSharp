public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxCurrent = nums[0] , maxGlobal = nums[0];
        for(int i=1;i<nums.Length;i++){
            maxCurrent = Math.Max(nums[i],maxCurrent+nums[i]);
            maxGlobal = Math.Max(maxCurrent,maxGlobal);
        }
        return maxGlobal;
    }
}