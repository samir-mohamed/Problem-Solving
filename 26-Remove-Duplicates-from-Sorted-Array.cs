public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        var k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary.Add(nums[i], i);
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}