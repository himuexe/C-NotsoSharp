public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k%nums.Length;
        reverse(nums,0,nums.Length-1);
        reverse(nums,0,k-1);
        reverse(nums,k,nums.Length-1);
    }
    void reverse(int[] nums , int left , int right){
        while(left < right){
            int temp = nums[left];
            nums[left]=nums[right];
            nums[right]=temp;
            left++;
            right--;
        }
    }
}