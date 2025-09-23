// C# Largest Element in an Array implementation in C#
 // Time Complexity: O(n)
class LargestElementArray
{
    static void Main()
    {
    int[] arr = { 34, 67, 23, 89, 12, 90, 45 };
    int largest = arr[0];        
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > largest)
        {
            largest = arr[i];
        }
    }
    Console.WriteLine("The largest element in the array is: " + largest);
    }
}