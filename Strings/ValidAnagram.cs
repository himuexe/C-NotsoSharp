public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        int[] arr = new int[26];
        for(int i=0;i<s.Length;i++){
            arr[s[i]-'a']++;
            arr[t[i]-'a']--;
        }
        foreach(int count in arr){
            if(count!=0){
                return false;
            }
        }
        return true;
    }
}