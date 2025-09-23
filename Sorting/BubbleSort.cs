// Bubble Sort Algorithm in C#
// Time Complexity: O(n^2) in worst and average case, O(n) in best case
using System;
class Sorting{
    public static void BubbleSort(int[] arr){
        bool isSwapped = false;
        for(int i=0;i<arr.Length;i++){
            isSwapped = false;
            for(int j=0;j<arr.Length-i-1;j++){
                if(arr[j]>arr[j+1]){
                    (arr[j+1], arr[j]) = (arr[j], arr[j+1]);
                    isSwapped = true;
                }
            }
            if(!isSwapped)break;
        }
    }
    public static void Main(){
        int[] arr = {5,3,8,9,1,1};
        BubbleSort(arr);
        Console.WriteLine(string.Join(", ",arr));
    }
}