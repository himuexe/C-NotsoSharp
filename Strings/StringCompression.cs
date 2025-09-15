public class Solution {
    public string CompressedString(string word) {
        StringBuilder newStr = new StringBuilder();
        for(int i=0;i<word.Length;i++){
            int count =1;
            while(i<word.Length-1 && word[i]==word[i+1]){
                i++;
                count++;
                if(count >= 9) break;
            }
            newStr.Append(count.ToString());
            newStr.Append(word[i]);
        }
        return newStr.ToString();
    }
}