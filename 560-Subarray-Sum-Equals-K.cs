public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>();
        dictionary[0] = 1;

        var sum = 0;
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (dictionary.ContainsKey(sum - k))
                result += dictionary[sum - k];

            if (dictionary.ContainsKey(sum))
                dictionary[sum]++;
            else
                dictionary.Add(sum, 1);
        }

        return result;
    }
}