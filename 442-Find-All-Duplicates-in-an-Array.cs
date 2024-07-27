public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var ans = new List<int>();

        var dictionary = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            if (dictionary.ContainsKey(nums[i]))
                ans.Add(nums[i]);
            else
                dictionary[nums[i]] = i;
        }

        return ans;
    }
}