public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n==0) return true;
        int count =0;
        for(int i=0;i<flowerbed.Length;i++){
            if(flowerbed[i]==0){
                bool left = (i==0) || (flowerbed[i-1]==0);
                bool right = (i == flowerbed.Length-1) || (flowerbed[i+1]==0);
                if(left && right){
                    flowerbed[i]=1;
                    count++;
                    if(count >= n) return true;
                } 
            }
        }
        return count >= n;
    }
}