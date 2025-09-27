public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int num in nums){
            dict[num] = dict.GetValueOrDefault(num,0)+1;
        }
        foreach(var el in dict){
            if(el.Value>nums.Length/2){
                return el.Key;
            }
        }
        return -1;
    }
}