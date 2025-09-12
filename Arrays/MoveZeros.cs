public class Solution {
    public void MoveZeroes(int[] nums) {
        int writeIndex=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                nums[writeIndex++]=nums[i];
            }
        }
        while(writeIndex<nums.Length){
            nums[writeIndex++]=0;
        }
    }
}