public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dictionary.ContainsKey(diff))
                return [dictionary[diff], i];
            
            dictionary.TryAdd(nums[i], i);
        }

        return [];
    }
}