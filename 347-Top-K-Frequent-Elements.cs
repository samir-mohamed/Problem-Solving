public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>();
        foreach (var num in nums)
            dictionary[num] = dictionary.GetValueOrDefault(num, 0) + 1;

        return dictionary.OrderByDescending(o => o.Value)
            .Select(o => o.Key)
            .Take(k)
            .ToArray();
    }
}