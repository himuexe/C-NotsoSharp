public class Solution {
    public void SortColors(int[] nums) {
        int left = 0 ,mid = 0 , right = nums.Length-1;
        while(mid <= right){
            if(nums[mid]==1){
                mid++;
            }
            else if(nums[mid]==0){
                swap(nums,mid,left);
                left++;
                mid++;
            }
            else {
                swap(nums,mid,right);
                right--;
            }
        }
    }
    void swap(int[] nums , int left , int right){
        int temp = nums[left];
        nums[left]=nums[right];
        nums[right]=temp;
    }
}