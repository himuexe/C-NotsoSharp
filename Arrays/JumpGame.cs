public class Solution {
    public bool CanJump(int[] nums) {
        int maxReachable =0;
        for(int i=0;i<nums.Length;i++){
            if(i>maxReachable) return false;
            maxReachable=Math.Max(maxReachable,i+nums[i]);
            if(maxReachable >= nums.Length-1) return true;
        }
        return true;
    }
}