public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach (int num in arr)
        {
        dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }
        HashSet<int> frequencySet = new HashSet<int>();
        foreach (int frequency in dict.Values) {
            if (frequencySet.Contains(frequency)) {
                return false;
            }
            frequencySet.Add(frequency);
        }
        return true;
    }
}