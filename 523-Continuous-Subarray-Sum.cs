public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        var dictionary = new Dictionary<int, int>();
        dictionary[0] = -1;
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            var remainder = sum % k;
            if (!dictionary.ContainsKey(remainder))
                dictionary[remainder] = i;
            else if (dictionary.ContainsKey(remainder) && (i - dictionary[remainder]) > 1)
                return true;
        }

        return false;
    }
}