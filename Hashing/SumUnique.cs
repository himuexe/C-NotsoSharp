public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int sum =0;
        foreach(int num in nums){
            dict[num]=dict.GetValueOrDefault(num,0)+1;
        }
        foreach(var s in dict){
            if(s.Value==1){
                sum += s.Key;
            }
        }
        return sum;
    }
}