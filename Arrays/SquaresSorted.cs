public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        int left=0,right=n-1,p=n-1;
        int[] squares = new int[n];
        while(left<=right){
            int leftSquare = nums[left]*nums[left];
            int rightSquare = nums[right]*nums[right];
            if(leftSquare>rightSquare){
                squares[p--]=leftSquare;
                left++;
            }
            else{
                squares[p--]=rightSquare;
                right--;
            }
        }
        return squares;
    }
}