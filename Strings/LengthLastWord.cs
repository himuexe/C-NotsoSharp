public class Solution {
    public int LengthOfLastWord(string s) {
        int p = s.Length-1,length=0;
        while(p>=0 && s[p]==' ')p--;
        while(p>=0 && s[p]!=' '){
            length++;
            p--;
        }
        return length;
    }
}