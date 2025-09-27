
public class Union 
{
    public static void Main(string[] args) 
    {
        int[] arr1 = {7, 3, 9};
        int[] arr2 = {6, 3, 9, 2, 9, 4};
        
        
        int[] union = arr1.Union(arr2).ToArray();
        int[] intersection = arr1.Intersect(arr2).ToArray();
        
        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine("Intersection: " + string.Join(", ", intersection));
    }
}