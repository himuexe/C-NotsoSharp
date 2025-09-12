public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] ans = {-1,-1};
        ans[0] = binarySearch(nums,target,true);
        if(ans[0] != -1) ans[1]=binarySearch(nums,target,false);
        return ans;
    }
    private int binarySearch(int[] nums , int target , bool first){
        int left=0,right=nums.Length-1,ans=-1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(nums[mid]<target){
                left = mid+1;
            }
            else if(nums[mid]>target){
                right=mid-1;
            }
            else{
                ans=mid;
                if(first){
                    right=mid-1;
                }
                else{
                    left=mid+1;
                }
            }
        }
        return ans;
    }
}