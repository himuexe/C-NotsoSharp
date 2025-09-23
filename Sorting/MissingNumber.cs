// Concept --> Cyclic Sort
// C# implementation to find the missing number in an array
// Leetcode Problem Link: https://leetcode.com/problems/missing-number/
// Time Complexity: O(n)
public class Solution {
    public int MissingNumber(int[] nums) {
        Sort(nums);
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=i)return i;
        }
        return nums.Length;
    }
    public static void Sort(int[] arr){
    int i=0;
    while(i<arr.Length){
        int correctPos=arr[i];
        if(arr[i] < arr.Length && arr[i] != arr[correctPos]){
            (arr[i],arr[correctPos])=(arr[correctPos],arr[i]);
        }
        else{
            i++;
        }
    }
}
}