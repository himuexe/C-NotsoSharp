public class Solution {
    public void NextPermutation(int[] nums) {
        int i = nums.Length-2;
        while(i >= 0 && nums[i]>=nums[i+1]) i--;
        if(i>=0){
            int j = nums.Length-1;
            while(j>=0 &&  nums[j]<=nums[i])j--;
            swap(nums,i,j);
        }
        reverse(nums,i+1);
    }
    private void swap(int[] nums, int left , int right){
        int temp = nums[left];
        nums[left]=nums[right];
        nums[right]=temp;
    }
    private void reverse(int[] nums , int left){
        int right = nums.Length-1;
        while(left < right){
            int temp = nums[left];
            nums[left]=nums[right];
            nums[right]=temp;  
            left++;
            right--;        
        }
    }
}