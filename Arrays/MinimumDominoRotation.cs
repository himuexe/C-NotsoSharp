public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int rotations = check(tops,bottoms,tops[0]);
        if(rotations != -1 )return rotations;
        return check(tops,bottoms,bottoms[0]);
    }
    private int check(int[] A , int[] B , int target){
        int rotationsA =0, rotationsB=0;
        for(int i=0;i<A.Length;i++){
            if(A[i]!= target && B[i]!=target) return -1;
            else if(A[i]!=target)rotationsA++;
            else if(B[i]!=target)rotationsB++;
        }
        return Math.Min(rotationsA,rotationsB);
    }
}