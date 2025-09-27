public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        dict.Add(0,1);
        int count =0 , currentSum=0;
        foreach(int num in nums){
            currentSum += num;
            if(dict.ContainsKey(currentSum-k)){
                count += dict[currentSum-k];
            }
            dict[currentSum]=dict.GetValueOrDefault(currentSum,0)+1;
        }
        return count;
    }

}